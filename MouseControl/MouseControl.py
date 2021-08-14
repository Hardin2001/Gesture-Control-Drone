from pynput.mouse import Button, Controller
mouse = Controller()

# Get mouse position:
mouse.position

# Set mouse position:
mouse.position = (500, 500)

# Scroll
mouse.scroll(0, 2)

# Press
mouse.press(Button.left)

