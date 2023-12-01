consul {
  address = "consul-server:8500"
}
deduplicate {
  enabled = true
  prefix = "consul-template/dedup/"
}
template {
  source = "/data/haproxy.ctmpl"
  destination = "/usr/local/etc/haproxy/haproxy.cfg"
  command = "/data/reconfigure_haproxy.sh"
}
wait {
  min = "5s"
  max = "10s"
}
