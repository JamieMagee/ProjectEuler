CFLAGS = -std=c++11

c++ %: 
	$(CXX) c++/$@.cc -o c++/$@ $(CFLAGS)