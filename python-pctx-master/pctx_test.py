import pctx
# from ctypes import *
# mydll = cdll.LoadLibrary("./PCTx.dll")
# mydll.Send(150,150,200,150,150,150,150,150,150,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)
c = pctx.Controller()
c.connect()

print('Test if the device is connected...', c.isConnected())


c.transmit(150,150,150,150,150,150,150,150,150)
c.updateChannel(3, 190)




# Update the first channel


