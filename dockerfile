FROM centos:7

MAINTAINER DrDeyzik <alexandrovau@gmail.com>

EXPOSE 9092
EXPOSE 2181

ENV JAVA_HOME=/usr/lib/jvm/jre-1.8.0-openjdk \
    JRE_HOME=/usr/java/lib/jvm/jre 

RUN yum -y install   wget java-1.8.0-openjdk.x86_64

WORKDIR /tmp
RUN wget http://www-us.apache.org/dist/kafka/0.10.2.1/kafka_2.11-0.10.2.1.tgz
RUN tar -xvf kafka_2.11-0.10.2.1.tgz
RUN mkdir /opt/kafka
RUN mv kafka_2.11-0.10.2.1/* /opt/kafka
RUN rm -rf /tmp/* 
WORKDIR /opt/kafka/bin

#RUN bin/zookeeper-server-start.sh -daemon config/zookeeper.properties
#RUN bin/kafka-server-start.sh config/server.properties
