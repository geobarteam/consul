FROM geobarteam/aspnetfrontend
WORKDIR /usr/local/bin
RUN wget https://releases.hashicorp.com/consul/0.7.2/consul_0.7.2_linux_amd64.zip
RUN apt-get update
RUN apt-get install unzip
RUN unzip consul_0.7.2_linux_amd64.zip
RUN mkdir /consul
RUN mkdir /consul/data
RUN mkdir /consul/config
WORKDIR /app





