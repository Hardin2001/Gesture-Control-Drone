from pynput.mouse import Button, Controller
import win32gui

mouse = Controller()
# (x0, y0) = mouse.position
#
#
# # Move to the toggle
# def MoveTo(x, y):
# 	mouse.position = (x, y)
#
# # Channel1 Left10


hwndMain = win32gui.FindWindow(None,"Endurance R/C - 9 Channel Controller Sample")
rect = win32gui.GetWindowRect(hwndMain)
initialPos = (rect[0],rect[1]) #(47,26)
initialLeftOffset = (120,52)
initialRightOffset = (391,52)
initialCenterOffset = (277,52)
y_axisOffset = 24
movementPerClick = 0.98
# Define the position here
channel1Left = (initialPos[0]+initialLeftOffset[0], initialPos[1]+initialLeftOffset[1])
channel1Right = (initialPos[0]+initialRightOffset[0], initialPos[1]+initialRightOffset[1])
channel1Center = (initialPos[0]+initialCenterOffset[0], initialPos[1]+initialCenterOffset[1])

FB_BY_THIS_VALUE = 6
TURN_BY_THIS_VALUE = 6
LR_BY_THIS_VALUE = 8
#Solution 1:
#Press the initial Position for 5 seconds/Click for 150 times, need to adjust the init position
#Solution 2:
#Record the current position and drag it back to initial position
#Solution 3:
#Have an action stack and undo previous actions

class ChannelQuery:

	def __init__(self):
		self.channelVal = [150] * 9
		for i in range(1,10):
			mouse.position = (channel1Left[0], channel1Left[1] + (i - 1) * y_axisOffset)
			mouse.click(Button.left, 6)
			self.channelVal[i - 1] -= 6
	def ChannelLeft(self, channel, value=0):
		if self.channelVal[channel - 1] < 144 :
			return
		if channel == 4:
			value = TURN_BY_THIS_VALUE
		if channel == 3:
			value = FB_BY_THIS_VALUE
		if channel == 2:
			value = LR_BY_THIS_VALUE
		mouse.position = (channel1Left[0], channel1Left[1] + (channel - 1) * y_axisOffset)
		mouse.click(Button.left, value)
		self.channelVal[channel - 1] -= value
	def ChannelRight(self, channel, value=0):
		if self.channelVal[channel - 1] > 144:
			return
		if channel == 4:
			value = TURN_BY_THIS_VALUE
		if channel == 3:
			value = FB_BY_THIS_VALUE
		if channel == 2:
			value = LR_BY_THIS_VALUE
		mouse.position = (channel1Right[0], channel1Right[1] + (channel - 1) * y_axisOffset)
		mouse.click(Button.left, value)
		self.channelVal[channel - 1] += value
	def resetChannel(self, channel, value=0):
		if channel == 4:
			value = TURN_BY_THIS_VALUE
		if channel == 3:
			value = FB_BY_THIS_VALUE
		if channel == 2:
			value = LR_BY_THIS_VALUE
		curVal = self.channelVal[channel - 1]
		if curVal < 144:
			self.ChannelRight(channel, 144 - curVal)
		elif self.channelVal[channel - 1] > 144:
			self.ChannelLeft(channel, curVal - 144)
	def resetAll(self):
		for i in range(1,10):
			self.resetChannel(i)
	def closeWindow(self):
		mouse.position = (initialPos[0] + 400, initialPos[1] + 10)
		mouse.click(Button.left)
	# drag back to initial position. Precision +- 1
	# if currentValue < 150:
	# 	mouse.position = (channel1Center[0] - movementPerClick * (150 - currentValue), channel1Center[1] + (channel-1) * y_axisOffset)
	# else:
	# 	mouse.position = (
	# 	channel1Center[0] + movementPerClick * (currentValue - 150), channel1Center[1] + (channel - 1) * y_axisOffset)
	#
	# mouse.press(Button.left)
	# newPos = (channel1Center[0]-1,channel1Center[1] + (channel-1) * y_axisOffset)
	# mouse.position = newPos
	# mouse.release(Button.left)
	# Click
	# mouse.click(Button.left, 40)

	# Press for 5 seconds
	# curTime = time.time()
	# mouse.press(Button.left)
	# while(time.time() - curTime < 3):
	# 	pass
	# mouse.release(Button.left)















