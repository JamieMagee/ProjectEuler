CFLAGS = -std=c++0x

c++ %: 
	$(CXX) c++/$@.cc -o c++/$@ $(CFLAGS)