#!/bin/bash
set -e

mkdir /data/consul.d
echo '{"service": {"name": "static-content", "tags": ["static-content"], "port": 80}}' > /data/consul.d/static-content.json
nohup consul agent -retry-join consul-server -data-dir=/data/consul-data -config-dir=/data/consul.d &>consul.log  &
sleep 3s
echo "consul agent started"
nginx
consul leave