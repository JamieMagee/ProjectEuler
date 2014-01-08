CFLAGS = -std=c++0x -O3

c++ %: 
	$(CXX) c++/$@.cc -o c++/$@ $(CFLAGS)