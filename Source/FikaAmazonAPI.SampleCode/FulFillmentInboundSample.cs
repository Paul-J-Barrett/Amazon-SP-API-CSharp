﻿using FikaAmazonAPI.Utils;
using FikaAmazonAPI.Services;
using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FikaAmazonAPI.SampleCode
{
    public class FulFillmentInboundSample
    {
        AmazonConnection amazonConnection;
        public FulFillmentInboundSample(AmazonConnection amazonConnection)
        {
            this.amazonConnection = amazonConnection;
        }
        
        public InboundShipmentList GetInboundShipments()
        {
            var param = new Parameter.FulFillmentInbound.ParameterGetShipments()
            {
                QueryType = Constants.QueryType.DATE_RANGE,
                MarketplaceId = MarketPlace.US.ID,
                ShipmentStatusList = (new List<ShipmentStatus>() { ShipmentStatus.CLOSED, ShipmentStatus.DELIVERED, ShipmentStatus.RECEIVING }),
                LastUpdatedAfter = DateTime.Now.AddDays(-60),
                LastUpdatedBefore = DateTime.Now
            };
            GetShipmentsResult results = null;
            var shipments = new InboundShipmentList();
            do
            {
                results = amazonConnection.FulFillmentInbound.GetShipments(param);
                shipments.AddRange(results.ShipmentData);
                //Console.WriteLine(results.NextToken);
                param.NextToken = results.NextToken;
                param.QueryType = Constants.QueryType.NEXT_TOKEN;
                foreach (var i in results.ShipmentData)
                {
                    Console.WriteLine($"{i.ShipmentId} {i.ShipmentStatus} {i.ConfirmedNeedByDate}");
                }
                //Thread.Sleep(5000);
            } while (String.IsNullOrEmpty(results.NextToken) != true);
            
            Console.WriteLine($"records downloaded: {shipments.Count}");
            return shipments;

        }
        public void GetInboundGuidance()
        {
            var parm = new Parameter.FulFillmentInbound.ParameterGetInboundGuidance()
            {
                MarketplaceId = MarketPlace.UnitedArabEmirates.ID,
                ASINList = new List<string> { "B071XVSXRL" }
            };

            amazonConnection.FulFillmentInbound.GetInboundGuidance(parm);
        }
        
        public void GetPrepInstructions()
        {
            var parm = new Parameter.FulFillmentInbound.ParameterGetPrepInstructions() {
                ShipToCountryCode = "AE",
                MarketplaceId= MarketPlace.UnitedArabEmirates.ID,
                ASINList =new List<string> { "B071XVSXRL" }
            };
            amazonConnection.FulFillmentInbound.GetPrepInstructions(parm);
        }

    }
}
