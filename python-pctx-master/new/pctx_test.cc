#include <stdio.h>
#include "pctx.h"
# include <iostream>
int main() {
std::cout << "Connecting...";
Controller pctx_dev;
pctx_dev.connect();

printf("Test if the device is connected...");
printf("%s", pctx_dev.isConnected() ? "true" : "false");

pctx_dev.transmit(512, 512, 512, 512, 512, 512, 512, 512, 512);


pctx_dev.updateChannel(1, 256);
  return 0;
}
