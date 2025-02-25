FROM pflixlab/rust-chef-protoc-env:latest as chef
WORKDIR /pfx-code

FROM chef AS planner
ARG https_proxy
ARG http_proxy

# COPY ./scripts/docker/cargo-config.toml /usr/local/cargo/config
COPY pallets pallets
COPY crates crates
COPY standalone standalone
COPY Cargo.toml Cargo.lock rustfmt.toml rust-toolchain.toml Makefile ./
RUN --mount=type=cache,target=/usr/local/cargo/registry cargo chef prepare --recipe-path recipe.json

## build Rust project use caching manner
FROM chef AS builder
ARG https_proxy
ARG http_proxy
ARG BUILD=release
ARG OA
ARG VC

COPY ./scripts/docker/cargo-config.toml /usr/local/cargo/config
COPY --from=planner /pfx-code/recipe.json recipe.json

# Build dependencies - this is the caching Docker layer!
RUN --mount=type=cache,target=/usr/local/cargo/registry cargo chef cook --release --recipe-path recipe.json

# Build application
COPY ./scripts/docker/cargo-config.toml /usr/local/cargo/config
COPY pallets pallets
COPY crates crates
COPY standalone standalone
COPY Cargo.toml Cargo.lock rustfmt.toml rust-toolchain.toml Makefile ./

RUN --mount=type=cache,target=/usr/local/cargo/registry make enfrost

## We do not need the Rust toolchain to run the binary!
FROM ubuntu:20.04 AS runtime

WORKDIR /opt/enfrost

COPY --from=builder /pfx-code/target/release/enfrost .

ENTRYPOINT ["./enfrost"]
