#!/usr/bin/env bash

if ! [ -x "$(command -v docker)" ]; then
  echo 'No docker CLI found, skipping' >&2
  exit 0
fi

# just for travis-ci
# https://docs.travis-ci.com/user/docker/
if [ "TRAVIS" = "true" ]; then
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
sudo add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable"
sudo apt-get update
sudo apt-get -y install docker-ce
fi

docker --version
docker build -t dotnet-core-http-loop-example .
docker run --rm dotnet-core-http-loop-example 8
