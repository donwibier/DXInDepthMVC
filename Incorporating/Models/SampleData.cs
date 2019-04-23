using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Incorporating.Models
{
	public class SampleData
	{
		static readonly object invoiceLock = new object();
		static readonly List<Invoice> _invoices = new List<Invoice>(new Invoice[] {

			new Invoice{InvoiceID = 4, CustomerID = 14, InvoiceDate = new DateTime(2009,1,6), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 9.00m },
			new Invoice{InvoiceID = 5, CustomerID = 23, InvoiceDate = new DateTime(2009,1,11), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 14.00m },







			new Invoice{InvoiceID = 13, CustomerID = 16, InvoiceDate = new DateTime(2009,2,19), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 1.00m },
			new Invoice{InvoiceID = 14, CustomerID = 17, InvoiceDate = new DateTime(2009,3,4), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 2.00m },
			new Invoice{InvoiceID = 15, CustomerID = 19, InvoiceDate = new DateTime(2009,3,4), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 2.00m },
			new Invoice{InvoiceID = 16, CustomerID = 21, InvoiceDate = new DateTime(2009,3,5), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 4.00m },
			new Invoice{InvoiceID = 17, CustomerID = 25, InvoiceDate = new DateTime(2009,3,6), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 6.00m },
			new Invoice{InvoiceID = 18, CustomerID = 31, InvoiceDate = new DateTime(2009,3,9), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 9.00m },


			new Invoice{InvoiceID = 21, CustomerID = 55, InvoiceDate = new DateTime(2009,4,4), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 2.00m },



			new Invoice{InvoiceID = 25, CustomerID = 10, InvoiceDate = new DateTime(2009,4,9), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 9.00m },
			new Invoice{InvoiceID = 26, CustomerID = 19, InvoiceDate = new DateTime(2009,4,14), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 14.00m },
			new Invoice{InvoiceID = 27, CustomerID = 33, InvoiceDate = new DateTime(2009,4,22), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 1.00m },




			new Invoice{InvoiceID = 32, CustomerID = 48, InvoiceDate = new DateTime(2009,5,10), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 9.00m },

			new Invoice{InvoiceID = 34, CustomerID = 12, InvoiceDate = new DateTime(2009,5,23), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 1.00m },
			new Invoice{InvoiceID = 35, CustomerID = 13, InvoiceDate = new DateTime(2009,6,5), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 2.00m },
			new Invoice{InvoiceID = 36, CustomerID = 15, InvoiceDate = new DateTime(2009,6,5), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 2.00m },
			new Invoice{InvoiceID = 37, CustomerID = 17, InvoiceDate = new DateTime(2009,6,6), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 4.00m },
			new Invoice{InvoiceID = 38, CustomerID = 21, InvoiceDate = new DateTime(2009,6,7), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 6.00m },
			new Invoice{InvoiceID = 39, CustomerID = 27, InvoiceDate = new DateTime(2009,6,10), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 9.00m },




			new Invoice{InvoiceID = 44, CustomerID = 55, InvoiceDate = new DateTime(2009,7,7), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 4.00m },


			new Invoice{InvoiceID = 47, CustomerID = 15, InvoiceDate = new DateTime(2009,7,16), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 14.00m },
			new Invoice{InvoiceID = 48, CustomerID = 29, InvoiceDate = new DateTime(2009,7,24), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 1.00m },
			new Invoice{InvoiceID = 49, CustomerID = 30, InvoiceDate = new DateTime(2009,8,6), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 2.00m },
			new Invoice{InvoiceID = 50, CustomerID = 32, InvoiceDate = new DateTime(2009,8,6), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 2.00m },






			new Invoice{InvoiceID = 57, CustomerID = 11, InvoiceDate = new DateTime(2009,9,6), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 2.00m },
			new Invoice{InvoiceID = 58, CustomerID = 13, InvoiceDate = new DateTime(2009,9,7), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 4.00m },
			new Invoice{InvoiceID = 59, CustomerID = 17, InvoiceDate = new DateTime(2009,9,8), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 6.00m },
			new Invoice{InvoiceID = 60, CustomerID = 23, InvoiceDate = new DateTime(2009,9,11), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 9.00m },
			new Invoice{InvoiceID = 61, CustomerID = 32, InvoiceDate = new DateTime(2009,9,16), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 14.00m },

			new Invoice{InvoiceID = 63, CustomerID = 47, InvoiceDate = new DateTime(2009,10,7), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 2.00m },


			new Invoice{InvoiceID = 66, CustomerID = 55, InvoiceDate = new DateTime(2009,10,9), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 6.00m },

			new Invoice{InvoiceID = 68, CustomerID = 11, InvoiceDate = new DateTime(2009,10,17), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 14.00m },
			new Invoice{InvoiceID = 69, CustomerID = 25, InvoiceDate = new DateTime(2009,10,25), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 1.00m },
			new Invoice{InvoiceID = 70, CustomerID = 26, InvoiceDate = new DateTime(2009,11,7), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 2.00m },
			new Invoice{InvoiceID = 71, CustomerID = 28, InvoiceDate = new DateTime(2009,11,7), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 2.00m },
			new Invoice{InvoiceID = 72, CustomerID = 30, InvoiceDate = new DateTime(2009,11,8), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 4.00m },







			new Invoice{InvoiceID = 80, CustomerID = 13, InvoiceDate = new DateTime(2009,12,10), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 6.00m },
			new Invoice{InvoiceID = 81, CustomerID = 19, InvoiceDate = new DateTime(2009,12,13), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 9.00m },
			new Invoice{InvoiceID = 82, CustomerID = 28, InvoiceDate = new DateTime(2009,12,18), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 14.00m },



			new Invoice{InvoiceID = 86, CustomerID = 47, InvoiceDate = new DateTime(2010,1,9), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 4.00m },



			new Invoice{InvoiceID = 90, CustomerID = 21, InvoiceDate = new DateTime(2010,1,26), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 1.00m },
			new Invoice{InvoiceID = 91, CustomerID = 22, InvoiceDate = new DateTime(2010,2,8), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 2.00m },
			new Invoice{InvoiceID = 92, CustomerID = 24, InvoiceDate = new DateTime(2010,2,8), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 2.00m },
			new Invoice{InvoiceID = 93, CustomerID = 26, InvoiceDate = new DateTime(2010,2,9), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 4.00m },
			new Invoice{InvoiceID = 94, CustomerID = 30, InvoiceDate = new DateTime(2010,2,10), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 6.00m },



			new Invoice{InvoiceID = 98, CustomerID = 1, InvoiceDate = new DateTime(2010,3,11), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 4.00m },
			new Invoice{InvoiceID = 99, CustomerID = 3, InvoiceDate = new DateTime(2010,3,11), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 4.00m },


			new Invoice{InvoiceID = 102, CustomerID = 15, InvoiceDate = new DateTime(2010,3,16), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 10.00m },
			new Invoice{InvoiceID = 103, CustomerID = 24, InvoiceDate = new DateTime(2010,3,21), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 16.00m },




			new Invoice{InvoiceID = 108, CustomerID = 47, InvoiceDate = new DateTime(2010,4,13), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 6.00m },

			new Invoice{InvoiceID = 110, CustomerID = 3, InvoiceDate = new DateTime(2010,4,21), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 14.00m },
			new Invoice{InvoiceID = 111, CustomerID = 17, InvoiceDate = new DateTime(2010,4,29), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 1.00m },
			new Invoice{InvoiceID = 112, CustomerID = 18, InvoiceDate = new DateTime(2010,5,12), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 2.00m },
			new Invoice{InvoiceID = 113, CustomerID = 20, InvoiceDate = new DateTime(2010,5,12), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 2.00m },
			new Invoice{InvoiceID = 114, CustomerID = 22, InvoiceDate = new DateTime(2010,5,13), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 4.00m },
			new Invoice{InvoiceID = 115, CustomerID = 26, InvoiceDate = new DateTime(2010,5,14), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 6.00m },
			new Invoice{InvoiceID = 116, CustomerID = 32, InvoiceDate = new DateTime(2010,5,17), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 9.00m },

			new Invoice{InvoiceID = 118, CustomerID = 55, InvoiceDate = new DateTime(2010,5,30), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 1.00m },


			new Invoice{InvoiceID = 121, CustomerID = 1, InvoiceDate = new DateTime(2010,6,13), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 4.00m },

			new Invoice{InvoiceID = 123, CustomerID = 11, InvoiceDate = new DateTime(2010,6,17), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 9.00m },
			new Invoice{InvoiceID = 124, CustomerID = 20, InvoiceDate = new DateTime(2010,6,22), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 14.00m },







			new Invoice{InvoiceID = 132, CustomerID = 13, InvoiceDate = new DateTime(2010,7,31), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 1.00m },
			new Invoice{InvoiceID = 133, CustomerID = 14, InvoiceDate = new DateTime(2010,8,13), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 2.00m },
			new Invoice{InvoiceID = 134, CustomerID = 16, InvoiceDate = new DateTime(2010,8,13), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 2.00m },
			new Invoice{InvoiceID = 135, CustomerID = 18, InvoiceDate = new DateTime(2010,8,14), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 4.00m },
			new Invoice{InvoiceID = 136, CustomerID = 22, InvoiceDate = new DateTime(2010,8,15), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 6.00m },
			new Invoice{InvoiceID = 137, CustomerID = 28, InvoiceDate = new DateTime(2010,8,18), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 9.00m },





			new Invoice{InvoiceID = 143, CustomerID = 1, InvoiceDate = new DateTime(2010,9,15), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 6.00m },

			new Invoice{InvoiceID = 145, CustomerID = 16, InvoiceDate = new DateTime(2010,9,23), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 14.00m },
			new Invoice{InvoiceID = 146, CustomerID = 30, InvoiceDate = new DateTime(2010,10,1), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 1.00m },
			new Invoice{InvoiceID = 147, CustomerID = 31, InvoiceDate = new DateTime(2010,10,14), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 2.00m },
			new Invoice{InvoiceID = 148, CustomerID = 33, InvoiceDate = new DateTime(2010,10,14), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 2.00m },





			new Invoice{InvoiceID = 154, CustomerID = 10, InvoiceDate = new DateTime(2010,11,14), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 2.00m },
			new Invoice{InvoiceID = 155, CustomerID = 12, InvoiceDate = new DateTime(2010,11,14), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 2.00m },
			new Invoice{InvoiceID = 156, CustomerID = 14, InvoiceDate = new DateTime(2010,11,15), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 4.00m },
			new Invoice{InvoiceID = 157, CustomerID = 18, InvoiceDate = new DateTime(2010,11,16), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 6.00m },
			new Invoice{InvoiceID = 158, CustomerID = 24, InvoiceDate = new DateTime(2010,11,19), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 9.00m },
			new Invoice{InvoiceID = 159, CustomerID = 33, InvoiceDate = new DateTime(2010,11,24), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 14.00m },
			new Invoice{InvoiceID = 160, CustomerID = 47, InvoiceDate = new DateTime(2010,12,2), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 1.00m },
			new Invoice{InvoiceID = 161, CustomerID = 48, InvoiceDate = new DateTime(2010,12,15), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 2.00m },



			new Invoice{InvoiceID = 165, CustomerID = 3, InvoiceDate = new DateTime(2010,12,20), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 9.00m },
			new Invoice{InvoiceID = 166, CustomerID = 12, InvoiceDate = new DateTime(2010,12,25), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 14.00m },
			new Invoice{InvoiceID = 167, CustomerID = 26, InvoiceDate = new DateTime(2011,1,2), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 1.00m },
			new Invoice{InvoiceID = 168, CustomerID = 27, InvoiceDate = new DateTime(2011,1,15), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 2.00m },
			new Invoice{InvoiceID = 169, CustomerID = 29, InvoiceDate = new DateTime(2011,1,15), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 2.00m },
			new Invoice{InvoiceID = 170, CustomerID = 31, InvoiceDate = new DateTime(2011,1,16), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 4.00m },






			new Invoice{InvoiceID = 177, CustomerID = 10, InvoiceDate = new DateTime(2011,2,16), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 4.00m },
			new Invoice{InvoiceID = 178, CustomerID = 14, InvoiceDate = new DateTime(2011,2,17), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 6.00m },
			new Invoice{InvoiceID = 179, CustomerID = 20, InvoiceDate = new DateTime(2011,2,20), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 9.00m },
			new Invoice{InvoiceID = 180, CustomerID = 29, InvoiceDate = new DateTime(2011,2,25), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 14.00m },



			new Invoice{InvoiceID = 184, CustomerID = 48, InvoiceDate = new DateTime(2011,3,19), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 4.00m },



			new Invoice{InvoiceID = 188, CustomerID = 22, InvoiceDate = new DateTime(2011,4,5), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 1.00m },
			new Invoice{InvoiceID = 189, CustomerID = 23, InvoiceDate = new DateTime(2011,4,18), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 2.00m },
			new Invoice{InvoiceID = 190, CustomerID = 25, InvoiceDate = new DateTime(2011,4,18), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 2.00m },
			new Invoice{InvoiceID = 191, CustomerID = 27, InvoiceDate = new DateTime(2011,4,19), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 4.00m },
			new Invoice{InvoiceID = 192, CustomerID = 31, InvoiceDate = new DateTime(2011,4,20), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 6.00m },


			new Invoice{InvoiceID = 195, CustomerID = 1, InvoiceDate = new DateTime(2011,5,6), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 1.00m },



			new Invoice{InvoiceID = 199, CustomerID = 10, InvoiceDate = new DateTime(2011,5,21), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 6.00m },
			new Invoice{InvoiceID = 200, CustomerID = 16, InvoiceDate = new DateTime(2011,5,24), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 9.00m },
			new Invoice{InvoiceID = 201, CustomerID = 25, InvoiceDate = new DateTime(2011,5,29), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 19.00m },




			new Invoice{InvoiceID = 206, CustomerID = 48, InvoiceDate = new DateTime(2011,6,21), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 9.00m },


			new Invoice{InvoiceID = 209, CustomerID = 18, InvoiceDate = new DateTime(2011,7,7), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 1.00m },
			new Invoice{InvoiceID = 210, CustomerID = 19, InvoiceDate = new DateTime(2011,7,20), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 2.00m },
			new Invoice{InvoiceID = 211, CustomerID = 21, InvoiceDate = new DateTime(2011,7,20), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 2.00m },
			new Invoice{InvoiceID = 212, CustomerID = 23, InvoiceDate = new DateTime(2011,7,21), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 4.00m },
			new Invoice{InvoiceID = 213, CustomerID = 27, InvoiceDate = new DateTime(2011,7,22), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 6.00m },
			new Invoice{InvoiceID = 214, CustomerID = 33, InvoiceDate = new DateTime(2011,7,25), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 9.00m },






			new Invoice{InvoiceID = 221, CustomerID = 12, InvoiceDate = new DateTime(2011,8,25), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 9.00m },
			new Invoice{InvoiceID = 222, CustomerID = 21, InvoiceDate = new DateTime(2011,8,30), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 14.00m },







			new Invoice{InvoiceID = 230, CustomerID = 14, InvoiceDate = new DateTime(2011,10,8), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 1.00m },
			new Invoice{InvoiceID = 231, CustomerID = 15, InvoiceDate = new DateTime(2011,10,21), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 2.00m },
			new Invoice{InvoiceID = 232, CustomerID = 17, InvoiceDate = new DateTime(2011,10,21), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 2.00m },
			new Invoice{InvoiceID = 233, CustomerID = 19, InvoiceDate = new DateTime(2011,10,22), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 4.00m },
			new Invoice{InvoiceID = 234, CustomerID = 23, InvoiceDate = new DateTime(2011,10,23), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 6.00m },
			new Invoice{InvoiceID = 235, CustomerID = 29, InvoiceDate = new DateTime(2011,10,26), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 9.00m },



			new Invoice{InvoiceID = 239, CustomerID = 55, InvoiceDate = new DateTime(2011,11,21), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 2.00m },



			new Invoice{InvoiceID = 243, CustomerID = 17, InvoiceDate = new DateTime(2011,12,1), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 14.00m },
			new Invoice{InvoiceID = 244, CustomerID = 31, InvoiceDate = new DateTime(2011,12,9), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 1.00m },
			new Invoice{InvoiceID = 245, CustomerID = 32, InvoiceDate = new DateTime(2011,12,22), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 2.00m },




			new Invoice{InvoiceID = 250, CustomerID = 55, InvoiceDate = new DateTime(2012,1,1), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 14.00m },
			new Invoice{InvoiceID = 251, CustomerID = 10, InvoiceDate = new DateTime(2012,1,9), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 1.00m },
			new Invoice{InvoiceID = 252, CustomerID = 11, InvoiceDate = new DateTime(2012,1,22), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 2.00m },
			new Invoice{InvoiceID = 253, CustomerID = 13, InvoiceDate = new DateTime(2012,1,22), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 2.00m },
			new Invoice{InvoiceID = 254, CustomerID = 15, InvoiceDate = new DateTime(2012,1,23), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 4.00m },
			new Invoice{InvoiceID = 255, CustomerID = 19, InvoiceDate = new DateTime(2012,1,24), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 6.00m },
			new Invoice{InvoiceID = 256, CustomerID = 25, InvoiceDate = new DateTime(2012,1,27), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 9.00m },

			new Invoice{InvoiceID = 258, CustomerID = 48, InvoiceDate = new DateTime(2012,2,9), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 1.00m },





			new Invoice{InvoiceID = 264, CustomerID = 13, InvoiceDate = new DateTime(2012,3,3), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 14.00m },
			new Invoice{InvoiceID = 265, CustomerID = 27, InvoiceDate = new DateTime(2012,3,11), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 1.00m },
			new Invoice{InvoiceID = 266, CustomerID = 28, InvoiceDate = new DateTime(2012,3,24), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 2.00m },
			new Invoice{InvoiceID = 267, CustomerID = 30, InvoiceDate = new DateTime(2012,3,24), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 2.00m },
			new Invoice{InvoiceID = 268, CustomerID = 32, InvoiceDate = new DateTime(2012,3,25), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 4.00m },






			new Invoice{InvoiceID = 275, CustomerID = 11, InvoiceDate = new DateTime(2012,4,25), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 4.00m },
			new Invoice{InvoiceID = 276, CustomerID = 15, InvoiceDate = new DateTime(2012,4,26), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 6.00m },
			new Invoice{InvoiceID = 277, CustomerID = 21, InvoiceDate = new DateTime(2012,4,29), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 9.00m },
			new Invoice{InvoiceID = 278, CustomerID = 30, InvoiceDate = new DateTime(2012,5,4), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 14.00m },


			new Invoice{InvoiceID = 281, CustomerID = 47, InvoiceDate = new DateTime(2012,5,25), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 2.00m },




			new Invoice{InvoiceID = 286, CustomerID = 23, InvoiceDate = new DateTime(2012,6,12), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 1.00m },
			new Invoice{InvoiceID = 287, CustomerID = 24, InvoiceDate = new DateTime(2012,6,25), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 2.00m },
			new Invoice{InvoiceID = 288, CustomerID = 26, InvoiceDate = new DateTime(2012,6,25), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 2.00m },
			new Invoice{InvoiceID = 289, CustomerID = 28, InvoiceDate = new DateTime(2012,6,26), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 4.00m },
			new Invoice{InvoiceID = 290, CustomerID = 32, InvoiceDate = new DateTime(2012,6,27), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 6.00m },

			new Invoice{InvoiceID = 292, CustomerID = 47, InvoiceDate = new DateTime(2012,7,5), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 14.00m },
			new Invoice{InvoiceID = 294, CustomerID = 3, InvoiceDate = new DateTime(2012,7,26), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 2.00m },
			new Invoice{InvoiceID = 297, CustomerID = 11, InvoiceDate = new DateTime(2012,7,28), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 6.00m },
			new Invoice{InvoiceID = 298, CustomerID = 17, InvoiceDate = new DateTime(2012,7,31), BillingAddress = "1 Microsoft Way", BillingCity = "Redmond", BillingState = "WA", BillingCountry = "USA", BillingPostalCode = "98052-8300", Total = 11.00m },
			new Invoice{InvoiceID = 299, CustomerID = 26, InvoiceDate = new DateTime(2012,8,5), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 24.00m },
			new Invoice{InvoiceID = 305, CustomerID = 55, InvoiceDate = new DateTime(2012,8,31), BillingAddress = "421 Bourke Street", BillingCity = "Sidney", BillingState = "NSW", BillingCountry = "Australia", BillingPostalCode = "2010", Total = 9.00m },
			new Invoice{InvoiceID = 307, CustomerID = 19, InvoiceDate = new DateTime(2012,9,13), BillingAddress = "1 Infinite Loop", BillingCity = "Cupertino", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "95014", Total = 2.00m },
			new Invoice{InvoiceID = 308, CustomerID = 20, InvoiceDate = new DateTime(2012,9,26), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 4.00m },
			new Invoice{InvoiceID = 309, CustomerID = 22, InvoiceDate = new DateTime(2012,9,26), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 4.00m },
			new Invoice{InvoiceID = 310, CustomerID = 24, InvoiceDate = new DateTime(2012,9,27), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 8.00m },
			new Invoice{InvoiceID = 311, CustomerID = 28, InvoiceDate = new DateTime(2012,9,28), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 12.00m },
			new Invoice{InvoiceID = 316, CustomerID = 1, InvoiceDate = new DateTime(2012,10,27), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 2.00m },
			new Invoice{InvoiceID = 317, CustomerID = 3, InvoiceDate = new DateTime(2012,10,28), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 4.00m },
			new Invoice{InvoiceID = 319, CustomerID = 13, InvoiceDate = new DateTime(2012,11,1), BillingAddress = "Qe 7 Bloco G", BillingCity = "Brasília", BillingState = "DF", BillingCountry = "Brazil", BillingPostalCode = "71020-677", Total = 9.00m },
			new Invoice{InvoiceID = 320, CustomerID = 22, InvoiceDate = new DateTime(2012,11,6), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 14.00m },
			new Invoice{InvoiceID = 327, CustomerID = 1, InvoiceDate = new DateTime(2012,12,7), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 14.00m },
			new Invoice{InvoiceID = 328, CustomerID = 15, InvoiceDate = new DateTime(2012,12,15), BillingAddress = "700 W Pender Street", BillingCity = "Vancouver", BillingState = "BC", BillingCountry = "Canada", BillingPostalCode = "V6C 1G8", Total = 1.00m },
			new Invoice{InvoiceID = 329, CustomerID = 16, InvoiceDate = new DateTime(2012,12,28), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 2.00m },
			new Invoice{InvoiceID = 330, CustomerID = 18, InvoiceDate = new DateTime(2012,12,28), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 2.00m },
			new Invoice{InvoiceID = 331, CustomerID = 20, InvoiceDate = new DateTime(2012,12,29), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 4.00m },
			new Invoice{InvoiceID = 332, CustomerID = 24, InvoiceDate = new DateTime(2012,12,30), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 6.00m },
			new Invoice{InvoiceID = 333, CustomerID = 30, InvoiceDate = new DateTime(2013,1,2), BillingAddress = "230 Elgin Street", BillingCity = "Ottawa", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "K2P 1L7", Total = 9.00m },
			new Invoice{InvoiceID = 339, CustomerID = 3, InvoiceDate = new DateTime(2013,1,30), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 6.00m },
			new Invoice{InvoiceID = 341, CustomerID = 18, InvoiceDate = new DateTime(2013,2,7), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 14.00m },
			new Invoice{InvoiceID = 342, CustomerID = 32, InvoiceDate = new DateTime(2013,2,15), BillingAddress = "696 Osborne Street", BillingCity = "Winnipeg", BillingState = "MB", BillingCountry = "Canada", BillingPostalCode = "R3L 2B9", Total = 1.00m },
			new Invoice{InvoiceID = 343, CustomerID = 33, InvoiceDate = new DateTime(2013,2,28), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 2.00m },
			new Invoice{InvoiceID = 347, CustomerID = 47, InvoiceDate = new DateTime(2013,3,5), BillingAddress = "Via Degli Scipioni, 43", BillingCity = "Rome", BillingState = "RM", BillingCountry = "Italy", BillingPostalCode = "00192", Total = 9.00m },
			new Invoice{InvoiceID = 349, CustomerID = 11, InvoiceDate = new DateTime(2013,3,18), BillingAddress = "Av. Paulista, 2022", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01310-200", Total = 1.00m },
			new Invoice{InvoiceID = 350, CustomerID = 12, InvoiceDate = new DateTime(2013,3,31), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 2.00m },
			new Invoice{InvoiceID = 351, CustomerID = 14, InvoiceDate = new DateTime(2013,3,31), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 2.00m },
			new Invoice{InvoiceID = 352, CustomerID = 16, InvoiceDate = new DateTime(2013,4,1), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 4.00m },
			new Invoice{InvoiceID = 353, CustomerID = 20, InvoiceDate = new DateTime(2013,4,2), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 6.00m },
			new Invoice{InvoiceID = 354, CustomerID = 26, InvoiceDate = new DateTime(2013,4,5), BillingAddress = "2211 W Berry Street", BillingCity = "Fort Worth", BillingState = "TX", BillingCountry = "USA", BillingPostalCode = "76110", Total = 9.00m },
			new Invoice{InvoiceID = 362, CustomerID = 14, InvoiceDate = new DateTime(2013,5,11), BillingAddress = "8210 111 ST NW", BillingCity = "Edmonton", BillingState = "AB", BillingCountry = "Canada", BillingPostalCode = "T6G 2C7", Total = 14.00m },
			new Invoice{InvoiceID = 363, CustomerID = 28, InvoiceDate = new DateTime(2013,5,19), BillingAddress = "302 S 700 E", BillingCity = "Salt Lake City", BillingState = "UT", BillingCountry = "USA", BillingPostalCode = "84102", Total = 1.00m },
			new Invoice{InvoiceID = 364, CustomerID = 29, InvoiceDate = new DateTime(2013,6,1), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 2.00m },
			new Invoice{InvoiceID = 365, CustomerID = 31, InvoiceDate = new DateTime(2013,6,1), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 2.00m },
			new Invoice{InvoiceID = 366, CustomerID = 33, InvoiceDate = new DateTime(2013,6,2), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 4.00m },
			new Invoice{InvoiceID = 372, CustomerID = 10, InvoiceDate = new DateTime(2013,7,2), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 2.00m },
			new Invoice{InvoiceID = 373, CustomerID = 12, InvoiceDate = new DateTime(2013,7,3), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 4.00m },
			new Invoice{InvoiceID = 374, CustomerID = 16, InvoiceDate = new DateTime(2013,7,4), BillingAddress = "1600 Amphitheatre Parkway", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94043-1351", Total = 6.00m },
			new Invoice{InvoiceID = 375, CustomerID = 22, InvoiceDate = new DateTime(2013,7,7), BillingAddress = "120 S Orange Ave", BillingCity = "Orlando", BillingState = "FL", BillingCountry = "USA", BillingPostalCode = "32801", Total = 9.00m },
			new Invoice{InvoiceID = 376, CustomerID = 31, InvoiceDate = new DateTime(2013,7,12), BillingAddress = "194A Chain Lake Drive", BillingCity = "Halifax", BillingState = "NS", BillingCountry = "Canada", BillingPostalCode = "B3S 1C5", Total = 14.00m },
			new Invoice{InvoiceID = 379, CustomerID = 48, InvoiceDate = new DateTime(2013,8,2), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 2.00m },
			new Invoice{InvoiceID = 382, CustomerID = 1, InvoiceDate = new DateTime(2013,8,7), BillingAddress = "Av. Brigadeiro Faria Lima, 2170", BillingCity = "São José dos Campos", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "12227-000", Total = 9.00m },
			new Invoice{InvoiceID = 383, CustomerID = 10, InvoiceDate = new DateTime(2013,8,12), BillingAddress = "Rua Dr. Falcão Filho, 155", BillingCity = "São Paulo", BillingState = "SP", BillingCountry = "Brazil", BillingPostalCode = "01007-010", Total = 14.00m },
			new Invoice{InvoiceID = 384, CustomerID = 24, InvoiceDate = new DateTime(2013,8,20), BillingAddress = "162 E Superior Street", BillingCity = "Chicago", BillingState = "IL", BillingCountry = "USA", BillingPostalCode = "60611", Total = 1.00m },
			new Invoice{InvoiceID = 385, CustomerID = 25, InvoiceDate = new DateTime(2013,9,2), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 2.00m },
			new Invoice{InvoiceID = 386, CustomerID = 27, InvoiceDate = new DateTime(2013,9,2), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 2.00m },
			new Invoice{InvoiceID = 387, CustomerID = 29, InvoiceDate = new DateTime(2013,9,3), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 4.00m },
			new Invoice{InvoiceID = 388, CustomerID = 33, InvoiceDate = new DateTime(2013,9,4), BillingAddress = "5112 48 Street", BillingCity = "Yellowknife", BillingState = "NT", BillingCountry = "Canada", BillingPostalCode = "X1A 1N6", Total = 6.00m },
			new Invoice{InvoiceID = 390, CustomerID = 48, InvoiceDate = new DateTime(2013,9,12), BillingAddress = "Lijnbaansgracht 120bg", BillingCity = "Amsterdam", BillingState = "VV", BillingCountry = "Netherlands", BillingPostalCode = "1016", Total = 14.00m },
			new Invoice{InvoiceID = 391, CustomerID = 3, InvoiceDate = new DateTime(2013,9,20), BillingAddress = "1498 rue Bélanger", BillingCity = "Montréal", BillingState = "QC", BillingCountry = "Canada", BillingPostalCode = "H2G 1A7", Total = 1.00m },
			new Invoice{InvoiceID = 395, CustomerID = 12, InvoiceDate = new DateTime(2013,10,5), BillingAddress = "Praça Pio X, 119", BillingCity = "Rio de Janeiro", BillingState = "RJ", BillingCountry = "Brazil", BillingPostalCode = "20040-020", Total = 6.00m },
			new Invoice{InvoiceID = 396, CustomerID = 18, InvoiceDate = new DateTime(2013,10,8), BillingAddress = "627 Broadway", BillingCity = "New York", BillingState = "NY", BillingCountry = "USA", BillingPostalCode = "10012-2612", Total = 9.00m },
			new Invoice{InvoiceID = 397, CustomerID = 27, InvoiceDate = new DateTime(2013,10,13), BillingAddress = "1033 N Park Ave", BillingCity = "Tucson", BillingState = "AZ", BillingCountry = "USA", BillingPostalCode = "85719", Total = 14.00m },
			new Invoice{InvoiceID = 405, CustomerID = 20, InvoiceDate = new DateTime(2013,11,21), BillingAddress = "541 Del Medio Avenue", BillingCity = "Mountain View", BillingState = "CA", BillingCountry = "USA", BillingPostalCode = "94040-111", Total = 1.00m },
			new Invoice{InvoiceID = 406, CustomerID = 21, InvoiceDate = new DateTime(2013,12,4), BillingAddress = "801 W 4th Street", BillingCity = "Reno", BillingState = "NV", BillingCountry = "USA", BillingPostalCode = "89503", Total = 2.00m },
			new Invoice{InvoiceID = 407, CustomerID = 23, InvoiceDate = new DateTime(2013,12,4), BillingAddress = "69 Salem Street", BillingCity = "Boston", BillingState = "MA", BillingCountry = "USA", BillingPostalCode = "2113", Total = 2.00m },
			new Invoice{InvoiceID = 408, CustomerID = 25, InvoiceDate = new DateTime(2013,12,5), BillingAddress = "319 N. Frances Street", BillingCity = "Madison", BillingState = "WI", BillingCountry = "USA", BillingPostalCode = "53703", Total = 4.00m },
			new Invoice{InvoiceID = 409, CustomerID = 29, InvoiceDate = new DateTime(2013,12,6), BillingAddress = "796 Dundas Street West", BillingCity = "Toronto", BillingState = "ON", BillingCountry = "Canada", BillingPostalCode = "M6J 1V1", Total = 6.00m }
		});
		

		public static IEnumerable<Invoice> Invoices { get { return _invoices; } }
	}

	public class Invoice
	{
		
		public Invoice()
		{
			
		}

		public int InvoiceID { get; set; }
		public int CustomerID { get; set; }
		public DateTime InvoiceDate { get; set; }
		public string BillingAddress { get; set; }
		public string BillingCity { get; set; }
		public string BillingState { get; set; }
		public string BillingCountry { get; set; }
		public string BillingPostalCode { get; set; }

		public decimal Total { get; set; }
	}
}