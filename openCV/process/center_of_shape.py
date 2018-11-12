
import argparse
import imutils
import cv2 as cv

# construct the argument parse and parse the arguments
ap = argparse.ArgumentParser()
ap.add_argument('-i', '--image', required=True, 
        help='path to the input image')
args = vars(ap.parse_args())

# load the image, convert it to grayscale, blur it slightly,
# and threshold it
image = cv.imread(args['image'])
gray = cv.cvtColor(image, cv.COLOR_BGR2GRAY)
blurred = cv.GaussianBlur(gray, (5, 5), 0)
thresh = cv.threshold(blurred, 60, 255, cv.THRESH_BINARY)[1]
#cv.imshow("Thresh", thresh)
#cv.waitKey(0)
#
## find contours in the thresholded image
img, cnts, hierarchy = cv.findContours(thresh.copy(), cv.RETR_EXTERNAL, 
        cv.CHAIN_APPROX_SIMPLE)

# Finds center of contours
for c in cnts:  # loop over the contours
    # compute the center of the contour
    M = cv.moments(c)
    cX = int(M["m10"] / M["m00"])
    cY = int(M["m01"] / M["m00"])
    
    # draw the contour and center of the shape on the image
    cv.drawContours(image, [c], -1, (0, 255, 0), 2)
    cv.circle(image, (cX, cY), 7, (255, 255, 255), -1)
    cv.putText(image, "center", (cX - 20, cY - 20), 
            cv.FONT_HERSHEY_SIMPLEX, 0.5, (255, 255, 255), 2)
    
    # show the image
    cv.imshow("Center of Shapes", image)
    cv.waitKey(500)

outName = args['image'][:-4]+'-p'+args['image'][-4:]
cv.imwrite(outName, image)
print(outName)
cv.waitKey(0)

#return "shapes-output.png"

