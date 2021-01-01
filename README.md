# Nconflux

 
 
# What is Nconflux?

Nconflux is the .Net integration library for Conflux, simplifying the access and smart contract interaction with Conflux nodes both public or permissioned like Gcfx, [Parity](https://www.parity.io/) or [Quorum](https://www.jpmorgan.com/global/Quorum).

Nconflux is developed targeting   netcore 3.1, .net 5, hence it is compatible with all the operating systems (Windows, Linux, MacOS, Android and OSX) and has been tested on cloud, mobile, desktop, Xbox, hololens and windows IoT.
 

## Issues, Requests and help

Please join our wechat account 1725325128

We should be able to answer there any simple queries, general comments or requests, everyone is welcome. In a similar feel free to raise any issue or pull request.

## Documentation
The documentation and guides can be found at [Read the docs](https://nconflux.readthedocs.io/en/latest/). 

## Features

* JSON RPC / IPC Conflux core methods. 
* Simplified smart contract interaction for deployment, function calling, transaction and event filtering and decoding of topics.
* ABI to .Net type encoding and decoding, including attribute based for complex object deserialization.
* Transaction, RLP and message signing, verification and recovery of accounts.
* Code generation of smart contracts services.

## Quick installation

Nconflux provides two types of packages. Standalone packages targeting Netstandard 1.1, net451 and where possible net351 to support Unity3d. There is also a Nconflux.Portable library which combines all the packages into a single portable library. As netstandard evolves and is more widely supported, the portable library might be eventually deprecated.

To install the latest version:

#### Windows users

To install the main packages you can either:

```
PM > Install-Package Nconflux.Web3
```
or 
```
PM > Install-Package Nconflux.Portable
```

#### Mac/Linux users

```
dotnet add package Nconflux.Web3 
``` 
or 
```
dotnet add package Nconflux.Portable
```
 
## Code samples

|  Source |  Description |
| ------------- |------------|
[Keystore generator](https://github.com/Nconflux/Nconflux/tree/master/src/Nconflux.KeyStore.Console.Sample)| Keystore file generator|
[Faucet](https://github.com/Nconflux/Nconflux.Faucet)| Web application template for an Cfx faucet |
[Nconflux Flappy](https://github.com/Nconflux/Nconflux.Flappy)| The source code files for the Unity3d game integrating with Conflux |
[Nconflux Game Sample](https://github.com/Nconflux/nconflux.game.sample)| Sample game demonstrating how to integrate Nconflux with [UrhoSharp's SamplyGame](https://github.com/xamarin/urho-samples/tree/master/SamplyGame) to build a cross-platform game interacting with Conflux |
[Nconflux UI wallet sample](https://github.com/Nconflux/nconflux.UI.wallet.sample)| Cross platform wallet example using Nconflux, Xamarin.Forms and MvvmCross, targeting: Android, iOS, Windows Mobile, Desktop (windows 10 uwp), IoT with the Raspberry PI and Xbox. |
|[Nconflux Windows wallet sample](https://github.com/Nconflux/Nconflux.SimpleWindowsWallet) | Windows forms wallet sample providing the core functionality for Loading accounts from different mediums, Cfx transfer, Standard token interaction. This is going to be the basis for the future cross-platform wallet / dapp |
[Nconflux Windows wallet sample](https://github.com/Nconflux/Nconflux.SimpleWindowsWallet) | Windows forms wallet sample providing the core functionality for Loading accounts from different mediums, Cfx transfer, Standard token interaction. This is going to be the basis for the future cross-platform wallet / dapp |
[Blazor/Blockchain Explorer](https://github.com/Nconflux/NconfluxBlazor) | Wasm blockchain explorer based on [Blazor](https://github.com/aspnet/Blazor) and [ReactiveUI](https://github.com/reactiveui/ReactiveUI)|

 

## Thanks  

* Many thanks to  
