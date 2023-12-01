FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS app_base
EXPOSE 5000
RUN apt-get update && apt-get install -y \
    libgdiplus \
    libc6-dev

FROM app_base AS node_base
RUN apt-get update && apt-get install -y wget unzip
WORKDIR /tmp 
ENV CONSUL_VER=1.5.2
RUN wget https://releases.hashicorp.com/consul/${CONSUL_VER}/consul_${CONSUL_VER}_linux_amd64.zip &&\
    unzip consul_${CONSUL_VER}_linux_amd64.zip &&\
    mv consul /usr/local/bin/
VOLUME [ "/data" ]

FROM node_base AS bin_only
WORKDIR /app
COPY . ./
RUN rm -rf conf/content/*

FROM nginx AS static_content
RUN apt-get update && apt-get install -y wget unzip
WORKDIR /tmp 
ENV CONSUL_VER=1.5.2
RUN wget https://releases.hashicorp.com/consul/${CONSUL_VER}/consul_${CONSUL_VER}_linux_amd64.zip &&\
    unzip consul_${CONSUL_VER}_linux_amd64.zip &&\
    mv consul /usr/local/bin/
VOLUME [ "/data" ]
VOLUME ["/content"]
COPY WebFarm/static-content/docker-entrypoint.sh /docker-entrypoint.sh
COPY conf/content /content
COPY WebFarm/static-content/nginx.conf /etc/nginx/nginx.conf
ENTRYPOINT ["/docker-entrypoint.sh"]

FROM node_base as final
COPY WebFarm/web-app/docker-entrypoint.sh /data/docker-entrypoint.sh
WORKDIR /app
COPY --from=bin_only /app .
RUN dotnet Terrasoft.WebHost.dll configureWebFarmMode
ENV ASPNETCORE_ENVIRONMENT Development
ENV TZ Europe/Kiev
ENTRYPOINT ["/data/docker-entrypoint.sh"]