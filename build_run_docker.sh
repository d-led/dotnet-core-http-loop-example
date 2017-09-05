#!/usr/bin/env bash

if ! [ -x "$(command -v docker)" ]; then
  echo 'No docker CLI found, skipping' >&2
  exit 0
fi

docker --version
docker build -t dotnet-core-http-loop-example .
docker run --rm dotnet-core-http-loop-example 8
