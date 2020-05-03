FROM ubuntu:18.04
RUN apt-get update && \
    apt-get install -y iproute2 &&\
    apt-get install -y python3 &&\
    apt-get install -y python3-pip

# Change default version to python 3
RUN ln -sf /usr/bin/python3 /usr/bin/python &&\
    pip3 install notebook &&\
    pip3 install pandas &&\
    pip3 install -U scikit-learn &&\
    pip3 install matplotlib
