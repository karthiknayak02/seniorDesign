
# https://www.codepool.biz/multiple-camera-opencv-python-windows.html

import cv2 as cv
import os
import sys

cap = cv.VideoCapture(0)

# filename is argument passed in
fname = 'openCV-Image.png'   # Default name in case of no arg
if sys.argv[1]:
    fname = sys.argv[1]
currName = fname

ret, frame = cap.read()
#cv.imshow('imshow', frame)

# Checks if name already exists, if so, add number at end of fname
if os.path.isfile(fname):
    i = 1
    currName = fname[:-4] + ' ({})'.format(i) + fname[-4:]
    while os.path.isfile(currName):
        i += 1
        currName = fname[:-4] + ' ({})'.format(i) + fname[-4:]
    fname = currName

cv.imwrite(fname, frame)

# Realease the capture
cap.release()
cv.destroyAllWindows()
