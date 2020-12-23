﻿using System;
using System.Threading.Tasks;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;
using Nethereum.Parity.RPC.Trace;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Nethereum.Parity.IntegrationTests.Tests.Trace
{
    public class TraceTransactionTester : RPCRequestTester<JArray>
    {
        public override async Task<JArray> ExecuteAsync(IClient client)
        {
            var senderAddress = "0x12890d2cce102216644c59daE5baed380d84830c";
            var privateKey = "0xb5b1870957d373ef0eeffecc6e4812c0fd08f554b37b233526acc331bf1544f7";
            var abi =
                @"[{""constant"":false,""inputs"":[{""name"":""val"",""type"":""int256""}],""name"":""multiply"",""outputs"":[{""name"":""d"",""type"":""int256""}],""type"":""function""},{""inputs"":[{""name"":""multiplier"",""type"":""int256""}],""type"":""constructor""}]";
            var byteCode =
                "0x60606040526040516020806052833950608060405251600081905550602b8060276000396000f3606060405260e060020a60003504631df4f1448114601a575b005b600054600435026060908152602090f3";

            var multiplier = 7;

            var web3 = new Web3.Web3(new Account(privateKey), client);

            //var receipt = await web3.TransactionManager.TransactionReceiptService.SendRequestAsync(new TransactionInput(){From = senderAddress, To = senderAddress, Value = new HexBigInteger(Web3.Web3.Convert.ToWei(1))});
            var receipt = await
                web3.Cfx.DeployContract.SendRequestAndWaitForReceiptAsync(abi, byteCode, senderAddress,
                    new HexBigInteger(900000), null, multiplier);


            var traceTransaction = new TraceTransaction(client);
            return await traceTransaction.SendRequestAsync(receipt.TransactionHash);
        }

        public override Type GetRequestType()
        {
            return typeof(TraceTransaction);
        }

        [Fact]
        public async void ShouldReturnTraceArray()
        {
            var result = await ExecuteAsync();
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }
    }
}
