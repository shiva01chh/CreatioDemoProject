#!/bin/bash
set -e

if [[ "$1" == "start" ]]; then
    echo "starting haproxy"
    haproxy -f /usr/local/etc/haproxy/haproxy.cfg
else
    echo "restarting haproxy"
    haproxy -D -f /usr/local/etc/haproxy/haproxy.cfg -st $(pidof haproxy)
fi
