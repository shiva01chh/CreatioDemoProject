FROM haproxy:1.7
RUN apt-get update && apt-get install -y wget unzip procps
WORKDIR /tmp 
ENV CONSUL_VER=1.5.2
ENV TINI_VERSION v0.18.0
ADD https://github.com/krallin/tini/releases/download/${TINI_VERSION}/tini /tini
RUN chmod +x /tini
RUN wget https://releases.hashicorp.com/consul-template/0.20.0/consul-template_0.20.0_linux_386.tgz &&\
    tar -xvzf consul-template_0.20.0_linux_386.tgz &&\
    mv consul-template /usr/local/bin
VOLUME [ "/data" ]
WORKDIR /data
RUN mkdir /var/run/haproxy/
COPY config.hcl /data/config.hcl
COPY haproxy.ctmpl /data/haproxy.ctmpl
COPY reconfigure_haproxy.sh /data/reconfigure_haproxy.sh
EXPOSE 80
#tini used to assign pid 0 to tini process instead of consul-template process (otherwise haproxy process will hang on restart)
ENTRYPOINT ["/tini", "--"]
CMD ["/usr/local/bin/consul-template", "-log-level", "debug", "-config", "/data/config.hcl"]