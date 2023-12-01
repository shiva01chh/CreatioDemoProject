#!/bin/bash
set -e

mkdir /data/consul.d
echo '{"service": {"name": "web-app", "tags": ["web-app"], "port": 5000}}' > /data/consul.d/web-app.json
nohup consul agent -retry-join consul-server -data-dir=/data/consul-data -config-dir=/data/consul.d &>consul.log  &
sleep 3s
echo "consul agent started"
dotnet Terrasoft.WebHost.dll
consul leave