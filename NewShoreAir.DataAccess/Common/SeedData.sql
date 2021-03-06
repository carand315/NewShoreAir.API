USE [NewShoreAirDB]
GO
SET IDENTITY_INSERT [dbo].[TRANSPORTS] ON 

INSERT [dbo].[TRANSPORTS] ([Id], [FlightCarrier], [FlightNumber]) VALUES (1, N'AV', N'001')
INSERT [dbo].[TRANSPORTS] ([Id], [FlightCarrier], [FlightNumber]) VALUES (2, N'VA', N'002')
SET IDENTITY_INSERT [dbo].[TRANSPORTS] OFF
SET IDENTITY_INSERT [dbo].[FLIGHTS] ON 

INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (1, 1, N'BOG', N'CAR', 700)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (2, 1, N'CAR', N'MED', 100)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (4, 2, N'MED', N'ARM', 100)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (5, 1, N'BOG', N'ARM', 700)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (6, 2, N'MED', N'BOG', 200)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (7, 2, N'BOG', N'MED', 300)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (8, 1, N'MED', N'ARM', 500)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (9, 2, N'ARM', N'CAR', 100)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (11, 2, N'CAR', N'MAN', 200)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (12, 1, N'MAN', N'BOG', 100)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (14, 2, N'BOG', N'SAN', 1200)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (17, 1, N'SAN', N'MAN', 1300)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (19, 2, N'MAN', N'CAL', 200)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (20, 2, N'MAN', N'CAR', 700)
INSERT [dbo].[FLIGHTS] ([Id], [TransportId], [Origin], [Destination], [Price]) VALUES (22, 1, N'CAL', N'MED', 500)
SET IDENTITY_INSERT [dbo].[FLIGHTS] OFF
