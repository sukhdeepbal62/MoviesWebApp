SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (1, N'Seasons')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (2, N'Science Fiction')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (3, N'Romance')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (4, N'Drama & Comedy')
GO
INSERT [dbo].[Categories] ([Id], [CategoryName]) VALUES (5, N'Action Thriller')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Directors] ON 
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (1, N'Raj & DK')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (2, N'Raghav Subbu')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (3, N'Patty Jenkins')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (4, N'Christian Rivers')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (5, N'Christopher Nolan')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (6, N' David Benioff, D. B. Weiss')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (7, N'Amit Golani')
GO
INSERT [dbo].[Directors] ([Id], [DirectorName]) VALUES (8, N'Johan Renck,')
GO
SET IDENTITY_INSERT [dbo].[Directors] OFF
GO
SET IDENTITY_INSERT [dbo].[Platforms] ON 
GO
INSERT [dbo].[Platforms] ([Id], [PlatformName]) VALUES (1, N'YouTube')
GO
INSERT [dbo].[Platforms] ([Id], [PlatformName]) VALUES (2, N'Amazon Prime')
GO
INSERT [dbo].[Platforms] ([Id], [PlatformName]) VALUES (3, N'Netflix')
GO
INSERT [dbo].[Platforms] ([Id], [PlatformName]) VALUES (4, N'Disney HotStar')
GO
SET IDENTITY_INSERT [dbo].[Platforms] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (1, N'Wonder Woman 1984', N'Wonder Woman finds herself battling two opponents, Maxwell Lord, a shrewd entrepreneur, and Barbara Minerva, a friend-turned-foe. Meanwhile, she also ends up crossing paths with her love interest.', 9.6, 2, 3, 5)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (2, N'Mortal Engines', N'In a post-apocalyptic world where cities move and consume each other to survive, two strangers come together to stop a sinister and destructive conspiracy.', 9.2, 3, 4, 2)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (3, N'Tenet', N'When a few objects that can be manipulated and used as weapons in the future fall into the wrong hands, a CIA operative, known as the Protagonist, must save the world.', 7.4, 2, 5, 5)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (4, N'The Family Man', N'Srikant Tiwari is a middle-class man who also serves as a world-class spy. Srikant tries to balance his familial responsibilities with the demands of the highly secretive special cell of the National Intelligence Agency that he is working for.', 8.6, 2, 1, 1)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (5, N'Game of Thrones', N'Nine noble families wage war against each other in order to gain control over the mythical land of Westeros. Meanwhile, a force is rising after millenniums and threatens the existence of living men.', 9.3, 4, 6, 1)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (6, N'Pitchers', N'TVF Pitchers is a web series created by The Viral Fever and developed by Arunabh Kumar. Written by Biswapati Sarkar, the series were directed by Amit Golani and features Naveen Kasturia, Arunabh Kumar, Jitendra Kumar and Abhay Mahajan.', 9.1, 1, 7, 1)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (7, N'Kota Factory', N'Kota Factory is an 2019 Indian Hindi-language web series created by Saurabh Khanna and directed by Raghav Subbu for The Viral Fever. The story is set is in Kota, which is a hub for many coaching centres where students come from all over India to prepare for various entrance exams', 9.2, 1, 2, 4)
GO
INSERT [dbo].[Movies] ([Id], [MovieName], [Description], [Rating], [PlatformID], [DirectorID], [CategoryID]) VALUES (8, N'Vikings', N'Ragnar Lothbrok, a legendary Norse hero, is a mere farmer who rises up to become a fearless warrior and commander of the Viking tribes with the support of his equally ferocious family.', 8.5, 3, 8, 1)
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
