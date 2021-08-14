CC=x86_64-w64-mingw32-g++
CPP=x86_64-w64-mingw32-g++
CFLAGS=-Wall -O2 -DLINUX 


BIN=python-pctx
PYTHON_DIR=G:/ProgramData/Anaconda3/include
all:	$(BIN)

clean:
	@echo "Cleaning up directory."
	rm -rf *~ *.o *.so *_wrap.* pctx.py *.pyc *.pyd $(BIN) 

pctx_test: pctx_test.o pctx.o
	$(CPP) $(CFLAGS)  $^ -o $@ -L./ -lusb-1.0 

python-pctx: pctx.o pctx_wrap.o
	$(CPP) -shared $^ G:\ProgramData\Anaconda3\python37.dll -o _pctx.so -L./ -lusb-1.0 

# object files
pctx.o: pctx.cc
	$(CPP) -c $^ -o $@

pctx_test.o: pctx_test.cc
	$(CPP) -c $^ -o $@

pctx_wrap.o: pctx_wrap.cc
	$(CPP) -c $^ -o $@ -I$(PYTHON_DIR)

pctx_wrap.cc: pctx.i
	swig -o $@ -python -c++ $^