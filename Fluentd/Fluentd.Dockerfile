FROM fluent/fluentd:v1.14.3-debian-1.0
USER root
RUN ["gem", "install","fluent-plugin-elasticsearch", "--version", "5.1.4"]
USER fluent