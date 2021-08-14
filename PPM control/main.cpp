#include <iostream>
#include "controller.h"

using namespace std;
controller *c;

void main(){
	c = new controller();
	c->startCycle();
}