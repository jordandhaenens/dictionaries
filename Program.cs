using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("TSLA", "Tesla Motors");
            stocks.Add("Ford", "Ford Motor Company");
            stocks.Add("TTF", "The Tree Farm");
            stocks.Add("CMLT", "Camelot");
            stocks.Add("GLAS", "Riedel Fine Glass");

            // foreach(KeyValuePair<string, string> stock in stocks){
            //     Console.WriteLine($"{stock.Value} {stock.Key}");
            // }

            // string car = stocks["TSLA"];
            // Console.WriteLine(stocks["TSLA"]);

            List<(string ticker, int shares, double price)> portfolio = new List<(string ticker, int shares, double price)>();
            portfolio.Add((ticker: "TSLA", shares: 150, price: 313.22));
            portfolio.Add((ticker: "TSLA", shares: 350, price: 310.22));
            portfolio.Add((ticker: "Ford", shares: 235, price: 11.26));
            portfolio.Add((ticker: "TTF", shares: 20, price: 5.13));
            portfolio.Add((ticker: "CMLT", shares: 8, price: 1500));
            portfolio.Add((ticker: "GLAS", shares: 35, price: 12.34));

            // foreach((string ticker, int shares, double price) item in portfolio){
            //     Console.WriteLine($"Your {item.ticker} shares have a total value of ${item.shares * item.price}");
            // }

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            stockReport.Add("Made", 5.32);
            // stockReport.Add("Tesla Motors", 67.4);

            string tick = "nothing";
            foreach((string ticker, int shares, double price) item in portfolio){
                tick = stocks[item.ticker];
                Console.WriteLine(tick);
                if(stockReport.ContainsKey(tick)){
                    //figure out how to update the value of a dictionary value item
                    stockReport[stocks[item.ticker]] += (item.shares * item.price);
                    Console.WriteLine($"stockReport contains key {item.ticker}");
                } 
                else {
                    double number = (item.shares * item.price);
                    stockReport.Add(stocks[item.ticker], number);
                }               
            }

            foreach(KeyValuePair<string, double> item in stockReport){
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
