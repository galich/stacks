# Stack trace comparison between Rust and C#

## Rust

```
thread 'main' panicked at 'something bad happened here', src/main.rs:16:5
stack backtrace:
   0: std::panicking::begin_panic
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/std/src/panicking.rs:519:12
   1: stacks_rs::process_one::{{closure}}
             at ./src/main.rs:16:5
   2: <core::future::from_generator::GenFuture<T> as core::future::future::Future>::poll
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/core/src/future/mod.rs:80:19
   3: stacks_rs::process_many::{{closure}}
             at ./src/main.rs:10:5
   4: <core::future::from_generator::GenFuture<T> as core::future::future::Future>::poll
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/core/src/future/mod.rs:80:19
   5: stacks_rs::main::{{closure}}::{{closure}}
             at ./src/main.rs:4:9
   6: <core::future::from_generator::GenFuture<T> as core::future::future::Future>::poll
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/core/src/future/mod.rs:80:19
   7: stacks_rs::main::{{closure}}
             at ./src/main.rs:3:5
   8: <core::future::from_generator::GenFuture<T> as core::future::future::Future>::poll
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/core/src/future/mod.rs:80:19
   9: tokio::park::thread::CachedParkThread::block_on::{{closure}}
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/park/thread.rs:263:54
  10: tokio::coop::with_budget::{{closure}}
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/coop.rs:106:9
  11: std::thread::local::LocalKey<T>::try_with
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/std/src/thread/local.rs:272:16
  12: std::thread::local::LocalKey<T>::with
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/std/src/thread/local.rs:248:9
  13: tokio::coop::with_budget
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/coop.rs:99:5
  14: tokio::coop::budget
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/coop.rs:76:5
  15: tokio::park::thread::CachedParkThread::block_on
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/park/thread.rs:263:31
  16: tokio::runtime::enter::Enter::block_on
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/runtime/enter.rs:151:13
  17: tokio::runtime::thread_pool::ThreadPool::block_on
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/runtime/thread_pool/mod.rs:71:9
  18: tokio::runtime::Runtime::block_on
             at /home/serg/.cargo/registry/src/github.com-1ecc6299db9ec823/tokio-1.3.0/src/runtime/mod.rs:452:43
  19: stacks_rs::main
             at ./src/main.rs:1:1
  20: core::ops::function::FnOnce::call_once
             at /home/serg/.rustup/toolchains/nightly-x86_64-unknown-linux-gnu/lib/rustlib/src/rust/library/core/src/ops/function.rs:227:5
note: Some details are omitted, run with `RUST_BACKTRACE=full` for a verbose backtrace.
```

# C#

```
System.Exception: something bad happened here
   at stacks_cs.Program.ProcessOne() in /home/serg/code/stacks/stacks-cs/Program.cs:line 27
   at stacks_cs.Program.ProcessMany() in /home/serg/code/stacks/stacks-cs/Program.cs:line 22
   at stacks_cs.Program.<>c.<<Main>b__0_0>d.MoveNext() in /home/serg/code/stacks/stacks-cs/Program.cs:line 13
```
