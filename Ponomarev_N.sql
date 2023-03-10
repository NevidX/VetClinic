USE [Ponomarev_N]
GO
/****** Object:  Table [dbo].[bolezn]    Script Date: 30.01.2023 17:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bolezn](
	[bcod] [int] NOT NULL,
	[bnam] [nvarchar](50) NULL,
	[bcount] [int] NULL,
 CONSTRAINT [PK_bolezn] PRIMARY KEY CLUSTERED 
(
	[bcod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[ccod] [int] NOT NULL,
	[cnam] [nvarchar](50) NULL,
	[cfam] [nvarchar](50) NULL,
	[cotch] [nvarchar](50) NULL,
	[ctel] [nvarchar](50) NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[ccod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dolg]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dolg](
	[dcod] [int] NOT NULL,
	[dnam] [nvarchar](50) NULL,
 CONSTRAINT [PK_dolg] PRIMARY KEY CLUSTERED 
(
	[dcod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oplata]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oplata](
	[ocod] [int] NOT NULL,
	[pcod] [int] NULL,
	[scod] [int] NULL,
	[ccod] [int] NULL,
	[ucod] [int] NULL,
	[ucena] [money] NULL,
	[odate] [datetime] NULL,
	[oplStatusCod] [int] NULL,
 CONSTRAINT [PK_oplata] PRIMARY KEY CLUSTERED 
(
	[ocod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[oplataStatus]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[oplataStatus](
	[oplStatusCod] [int] NOT NULL,
	[oplStatusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_oplataStatus] PRIMARY KEY CLUSTERED 
(
	[oplStatusCod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pet]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pet](
	[pcod] [int] NOT NULL,
	[pnam] [nvarchar](50) NULL,
	[pvozrast] [int] NULL,
	[pvid] [nvarchar](50) NULL,
	[pprotiv] [nvarchar](500) NULL,
	[posoben] [nvarchar](500) NULL,
	[ccod] [int] NULL,
 CONSTRAINT [PK_pet] PRIMARY KEY CLUSTERED 
(
	[pcod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sotr]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sotr](
	[scod] [int] NOT NULL,
	[snam] [nvarchar](50) NULL,
	[sfam] [nvarchar](50) NULL,
	[sotch] [nvarchar](50) NULL,
	[stel] [nvarchar](50) NULL,
	[dcod] [int] NULL,
	[slogin] [nvarchar](50) NULL,
	[spass] [nvarchar](50) NULL,
 CONSTRAINT [PK_sotr] PRIMARY KEY CLUSTERED 
(
	[scod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[statusCod] [int] NOT NULL,
	[statusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[statusCod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uslugi]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uslugi](
	[ucod] [int] NOT NULL,
	[unam] [nvarchar](50) NULL,
	[ucena] [int] NULL,
 CONSTRAINT [PK_uslugi] PRIMARY KEY CLUSTERED 
(
	[ucod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[zapic]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[zapic](
	[zcod] [int] NOT NULL,
	[ccod] [int] NULL,
	[pcod] [int] NOT NULL,
	[scod] [int] NULL,
	[zdate] [datetime] NULL,
	[zdate2] [datetime] NULL,
	[zmethod] [nvarchar](500) NULL,
	[statusCod] [int] NULL,
	[bcod] [int] NOT NULL,
	[dcod] [int] NULL,
	[ucod] [int] NULL,
 CONSTRAINT [PK_zapic] PRIMARY KEY CLUSTERED 
(
	[zcod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (1, N'Абсцесс', 3)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (2, N'Актиномикоз', 15)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (3, N'Аллергический бронхит', 6)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (4, N'Анемия', 13)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (5, N'Астма', 8)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (6, N'Бронхит', 4)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (7, N'Бруцеллез', 8)
INSERT [dbo].[bolezn] ([bcod], [bnam], [bcount]) VALUES (8, N'Гастрит хронический', 3)
GO
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (2, N'Михаил', N'Шубин', N'Иванович', N'+7-912-822-20-55')
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (3, N'Иван', N'Петров', N'Сергеевич', N'+7-912-822-90-10')
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (4, N'Александр', N'Петров', N'Александрович', N'+7-912-822-90-33')
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (6, N'Влад', N'Воронжцов', N'Генадьевич', N'+7-222-222-13-23')
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (8, N'Виталий', N'Шариков', N'Сергеевич', N'+7-244-242-42-42')
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (10, N'Никита', N'Петров', N'Александрович', N'+7-912-822-90-11')
INSERT [dbo].[client] ([ccod], [cnam], [cfam], [cotch], [ctel]) VALUES (11, N'Николай', N'Дмитриев', N'Миронович', N'+7-912-822-22-55')
GO
INSERT [dbo].[dolg] ([dcod], [dnam]) VALUES (1, N'врач-ветеринар')
INSERT [dbo].[dolg] ([dcod], [dnam]) VALUES (2, N'администратор')
INSERT [dbo].[dolg] ([dcod], [dnam]) VALUES (3, N'системный администратор')
GO
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (1, 6, 4, 2, 1, NULL, CAST(N'2023-01-19T09:35:36.150' AS DateTime), 3)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (2, 9, 4, 4, 1, NULL, CAST(N'2023-01-19T09:35:39.777' AS DateTime), 2)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (3, 9, NULL, 4, 1, NULL, CAST(N'2023-01-19T09:35:43.450' AS DateTime), 1)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (4, 8, 5, 3, 1, 220.0000, CAST(N'2023-01-29T14:57:06.440' AS DateTime), 1)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (5, 8, 5, 3, 1, 220.0000, CAST(N'2023-01-30T17:29:29.253' AS DateTime), 2)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (6, 12, 7, 8, 1, 220.0000, CAST(N'2023-01-30T17:30:13.303' AS DateTime), 2)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (7, 15, 12, 6, 1, 220.0000, CAST(N'2023-01-30T17:31:08.560' AS DateTime), 2)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (8, 9, 10, 4, 1, 220.0000, CAST(N'2023-01-30T11:12:51.170' AS DateTime), 1)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (9, 19, 13, 10, 12, 220.0000, CAST(N'2023-01-30T17:31:19.653' AS DateTime), 3)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (10, 22, 13, 4, 3, 500.0000, CAST(N'2023-01-30T17:31:49.373' AS DateTime), 3)
INSERT [dbo].[oplata] ([ocod], [pcod], [scod], [ccod], [ucod], [ucena], [odate], [oplStatusCod]) VALUES (11, 24, 7, 11, 5, 400.0000, CAST(N'2023-01-30T17:37:51.820' AS DateTime), 2)
GO
INSERT [dbo].[oplataStatus] ([oplStatusCod], [oplStatusName]) VALUES (1, N'В ожидании')
INSERT [dbo].[oplataStatus] ([oplStatusCod], [oplStatusName]) VALUES (2, N'Оплачено')
INSERT [dbo].[oplataStatus] ([oplStatusCod], [oplStatusName]) VALUES (3, N'Отказано')
GO
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (6, N'Барсик', 4, N'Кот', N'-', N'-', 2)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (8, N'Вася', 2, N'Хомяк', N'-', N'-', 3)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (9, N'Мишка', 3, N'Собака', N'Аллергия на сыр', N'Хвост в полоску', 4)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (10, N'Кеша', 2, N'Попугай', N'-', N'-', NULL)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (11, N'Скиф', 2, N'Собака', N'-', N'-', NULL)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (12, N'Клот', 2, N'Кот', N'', N'', 8)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (14, N'Пип', 1, N'Попугай', N'', N'', NULL)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (15, N'Люк', 4, N'Кот', N'Аллергия на цветы', N'Правое ухо загнуто ', 6)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (16, N'Кузя', 4, N'Кошка', N'Аллергия на сыр', N'Хвост полосатый', NULL)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (17, N'Кузя', 3, N'Кот', N'', N'', NULL)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (18, N'Кузя', 3, N'Кот', N'', N'', NULL)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (19, N'Кузя', 3, N'Кот', N'Аллергия на хворост', N'Правая нога хромает', 10)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (20, N'Гоша', 4, N'Попугай', N'-', N'-', 2)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (21, N'Шурик', 3, N'Кот', N'Аллергия на шоколад', N'Правая нога с пятном', 3)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (22, N'Корик', 3, N'Собака', N'Аллергия на апельсины', N'Нога скошена', 4)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (23, N'Орик', 2, N'Кот', N'Аллергия на бананы', N'Правая задняя нога без когтей', 6)
INSERT [dbo].[pet] ([pcod], [pnam], [pvozrast], [pvid], [pprotiv], [posoben], [ccod]) VALUES (24, N'Ева', 2, N'Кошка', N'', N'', 11)
GO
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (1, N'Сергей', N'Шарин', N'Иванович', N'+7-123-456-22-32', 1, N'aleksey2', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (4, N'Ариана', N'Петрова', N'Евгеньевна', N'+7-912-822-22-26', 1, N'aa', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (5, N'Ариана', N'Шишкина', N'Сергеевна', N'+7-912-822-22-21', 1, N'Ariana22', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (6, N'Алексей', N'Кудрин', N'Иванович', N'+7-123-456-22-22', 1, N'Aleksey23', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (7, N'Андрей', N'Игорьев', N'Александрович', N'+7-123-456-22-11', 1, N'Vrach', N'1')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (8, N'Сергей', N'Сердуков', N'Генадьевич', N'+7-912-822-90-10', 2, N'Admin', N'1')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (9, N'Никита', N'Пономарев', N'Русланович', N'+7-912-822-90-12', 3, N'sysAdmin', N'1')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (10, N'Богдан', N'Пушкарев', N'Генадьевич', N'+7-912-822-90-22', 1, N'Vrach2', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (11, N'Андрей', N'Феденистов', N'Генадьевич', N'+7-912-822-22-32', 1, N'and1', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (12, N'Генадий', N'Христолюбов', N'Александрович', N'+7-912-822-50-34', 1, N'igor1', N'12345678')
INSERT [dbo].[sotr] ([scod], [snam], [sfam], [sotch], [stel], [dcod], [slogin], [spass]) VALUES (13, N'Григорий', N'Зункевич', N'Александрович', N'+7-912-822-50-12', 1, N'grig1', N'12345678')
GO
INSERT [dbo].[status] ([statusCod], [statusName]) VALUES (1, N'В работе')
INSERT [dbo].[status] ([statusCod], [statusName]) VALUES (2, N'Готово')
INSERT [dbo].[status] ([statusCod], [statusName]) VALUES (3, N'Отказ')
GO
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (1, N'Первичный прием', 220)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (2, N'Стерилизация кошки', 300)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (3, N'Стерилизация большой собаки', 500)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (4, N'Подрезание когтей кошкам, котам', 50)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (5, N'Взятие крови', 400)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (6, N'Обработка раны', 100)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (7, N'Лечение переломов костей', 500)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (8, N'Чистка ушных раковин', 100)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (9, N'Вакцинация кошки от бешенства', 600)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (10, N'Вакцинация собаки комплексная', 500)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (11, N'Биохимический анализ', 220)
INSERT [dbo].[uslugi] ([ucod], [unam], [ucena]) VALUES (12, N'Анализ крови', 220)
GO
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (1, 2, 6, 4, CAST(N'2023-01-13T14:50:51.000' AS DateTime), CAST(N'2023-01-29T12:07:06.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра кота по кличке Барсик были проведены общие и специальные исследования.

При общем исследовании отклонений выявлено не было. Кот внешне здоров. Кожные и волосяные покровы в норме. Слизистые бледно-розовые. Лимфатические узлы не воспалены. Повышение температуры не наблюдалось. Аппетит и жажда исследуемого животного в норме. Акты дефекации и мочеиспускания регулярны, безболезненны.
', 2, 4, 1, 1)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (9, 8, 12, 7, CAST(N'2023-01-29T13:30:33.000' AS DateTime), CAST(N'2023-01-30T10:43:51.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра кота по кличке Клот были проведены общие и специальные исследования.

При общем исследовании отклонений выявлено не было. Кот внешне здоров. Кожные и волосяные покровы в норме. Слизистые бледно-розовые. Лимфатические узлы не воспалены. Повышение температуры не наблюдалось. Аппетит и жажда исследуемого животного в норме. Акты дефекации и мочеиспускания регулярны, безболезненны.', 2, 3, 1, 1)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (11, 3, 8, 5, CAST(N'2023-01-25T15:30:54.000' AS DateTime), CAST(N'2023-01-29T15:09:53.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра кота по кличке Вася были проведены общие и специальные исследования.
В ходе исследования выяснили, что болезнь хроническая.
', 2, 2, 1, 1)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (12, 6, 15, 12, CAST(N'2023-01-25T10:45:18.000' AS DateTime), CAST(N'2023-01-30T11:12:30.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра питомца по кличке Люк были проведены общие и специальные исследования.
В ходе исследования выяснили, что болезнь хроническая.
', 2, 4, 1, 1)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (13, 4, 9, 10, CAST(N'2023-01-30T10:46:08.367' AS DateTime), CAST(N'2023-01-30T11:12:51.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра питомца по кличке Мишка были проведены общие и специальные исследования.
В ходе исследования выяснили, что болезнь хроническая.', 2, 5, 1, 1)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (14, 10, 19, 13, CAST(N'2023-01-21T10:50:24.000' AS DateTime), CAST(N'2023-01-30T11:13:01.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра питомца по кличке Кузя были проведены общие и специальные исследования.
В ходе исследования выяснили, что болезнь хроническая.', 2, 6, 1, 12)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (15, 2, 20, 7, CAST(N'2023-01-30T11:13:23.177' AS DateTime), CAST(N'2023-01-30T11:32:00.000' AS DateTime), N'', 3, 7, 1, 4)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (16, 3, 21, 7, CAST(N'2023-01-30T11:29:23.857' AS DateTime), CAST(N'2023-01-30T11:32:08.000' AS DateTime), N'', 3, 6, 1, 2)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (17, 4, 22, 13, CAST(N'2023-01-25T11:29:41.000' AS DateTime), CAST(N'2023-01-30T11:32:30.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра кота по кличке Корик были проведены общие и специальные исследования.
В ходе исследования выяснили, что болезнь хроническая.
', 2, 8, 1, 3)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (18, 6, 23, 11, CAST(N'2023-01-11T11:30:28.000' AS DateTime), NULL, NULL, 1, 7, 1, 11)
INSERT [dbo].[zapic] ([zcod], [ccod], [pcod], [scod], [zdate], [zdate2], [zmethod], [statusCod], [bcod], [dcod], [ucod]) VALUES (19, 11, 24, 7, CAST(N'2023-01-25T12:30:39.000' AS DateTime), CAST(N'2023-01-30T17:37:36.000' AS DateTime), N'Обследование животного имело профилактический характер. В ходе клинического осмотра кошки по кличке Ева были проведены общие и специальные исследования.
В ходе исследования выяснили, что болезнь хроническая.
', 2, 7, 1, 5)
GO
ALTER TABLE [dbo].[oplata]  WITH CHECK ADD  CONSTRAINT [FK_oplata_client] FOREIGN KEY([ccod])
REFERENCES [dbo].[client] ([ccod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[oplata] CHECK CONSTRAINT [FK_oplata_client]
GO
ALTER TABLE [dbo].[oplata]  WITH CHECK ADD  CONSTRAINT [FK_oplata_oplataStatus] FOREIGN KEY([oplStatusCod])
REFERENCES [dbo].[oplataStatus] ([oplStatusCod])
GO
ALTER TABLE [dbo].[oplata] CHECK CONSTRAINT [FK_oplata_oplataStatus]
GO
ALTER TABLE [dbo].[oplata]  WITH CHECK ADD  CONSTRAINT [FK_oplata_pet] FOREIGN KEY([pcod])
REFERENCES [dbo].[pet] ([pcod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[oplata] CHECK CONSTRAINT [FK_oplata_pet]
GO
ALTER TABLE [dbo].[oplata]  WITH CHECK ADD  CONSTRAINT [FK_oplata_sotr] FOREIGN KEY([scod])
REFERENCES [dbo].[sotr] ([scod])
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[oplata] CHECK CONSTRAINT [FK_oplata_sotr]
GO
ALTER TABLE [dbo].[oplata]  WITH CHECK ADD  CONSTRAINT [FK_oplata_uslugi] FOREIGN KEY([ucod])
REFERENCES [dbo].[uslugi] ([ucod])
GO
ALTER TABLE [dbo].[oplata] CHECK CONSTRAINT [FK_oplata_uslugi]
GO
ALTER TABLE [dbo].[pet]  WITH CHECK ADD  CONSTRAINT [FK_pet_client] FOREIGN KEY([ccod])
REFERENCES [dbo].[client] ([ccod])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[pet] CHECK CONSTRAINT [FK_pet_client]
GO
ALTER TABLE [dbo].[sotr]  WITH CHECK ADD  CONSTRAINT [FK_sotr_dolg] FOREIGN KEY([dcod])
REFERENCES [dbo].[dolg] ([dcod])
GO
ALTER TABLE [dbo].[sotr] CHECK CONSTRAINT [FK_sotr_dolg]
GO
ALTER TABLE [dbo].[zapic]  WITH CHECK ADD  CONSTRAINT [FK_zapic_bolezn] FOREIGN KEY([bcod])
REFERENCES [dbo].[bolezn] ([bcod])
GO
ALTER TABLE [dbo].[zapic] CHECK CONSTRAINT [FK_zapic_bolezn]
GO
ALTER TABLE [dbo].[zapic]  WITH CHECK ADD  CONSTRAINT [FK_zapic_client] FOREIGN KEY([ccod])
REFERENCES [dbo].[client] ([ccod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[zapic] CHECK CONSTRAINT [FK_zapic_client]
GO
ALTER TABLE [dbo].[zapic]  WITH CHECK ADD  CONSTRAINT [FK_zapic_pet] FOREIGN KEY([pcod])
REFERENCES [dbo].[pet] ([pcod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[zapic] CHECK CONSTRAINT [FK_zapic_pet]
GO
ALTER TABLE [dbo].[zapic]  WITH CHECK ADD  CONSTRAINT [FK_zapic_sotr] FOREIGN KEY([scod])
REFERENCES [dbo].[sotr] ([scod])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[zapic] CHECK CONSTRAINT [FK_zapic_sotr]
GO
ALTER TABLE [dbo].[zapic]  WITH CHECK ADD  CONSTRAINT [FK_zapic_status] FOREIGN KEY([statusCod])
REFERENCES [dbo].[status] ([statusCod])
GO
ALTER TABLE [dbo].[zapic] CHECK CONSTRAINT [FK_zapic_status]
GO
/****** Object:  Trigger [dbo].[bolezn_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[bolezn_id]
on [dbo].[bolezn] instead of insert as 
declare @count int, @bnam nvarchar(50), @bcod int,@bcount int

select @bcod = COUNT(bcod) from bolezn

if(@bcod=0)
begin
select @count = 0
end
else
begin
select @count=max(bcod) from bolezn
end

select @bnam=ins.bnam from inserted ins 
insert into bolezn(bcod,bnam,bcount) values (@count+1,@bnam,0) 
GO
ALTER TABLE [dbo].[bolezn] ENABLE TRIGGER [bolezn_id]
GO
/****** Object:  Trigger [dbo].[client_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[client_id]
on [dbo].[client] instead of insert as 
declare @count int, @cnam nvarchar(50),@cfam nvarchar(50),@cotch nvarchar(50),@ctel nvarchar(50), @ccod int

select @ccod = COUNT(ccod) from client

if(@ccod=0)
begin
select @count = 0
end
else
begin
select @count=max(ccod) from client
end

select @cnam=ins.cnam, @cfam=ins.cfam,@cotch=ins.cotch,@ctel=ins.ctel from inserted ins 
insert into client(ccod,cnam,cfam,cotch,ctel) values (@count+1,@cnam,@cfam,@cotch,@ctel) 
GO
ALTER TABLE [dbo].[client] ENABLE TRIGGER [client_id]
GO
/****** Object:  Trigger [dbo].[oplata_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[oplata_id]
on [dbo].[oplata] instead of insert as 
declare @count int, @pcod int,@scod int,@ccod int,@ucod int,@ucena int, @odate datetime,@oplStatusCod int, @ocod int

select @ocod = COUNT(ocod) from oplata

if(@ocod=0)
begin
select @count = 0
end
else
begin
select @count=max(ocod) from oplata
end

select @pcod=ins.pcod, @scod=ins.scod,@ccod=ins.ccod,@ucod=ins.ucod,@ucena=ins.ucena,@odate=ins.odate,@oplStatusCod=ins.oplStatusCod from inserted ins 
insert into oplata(ocod,pcod,scod,ccod,ucod,ucena,odate,oplStatusCod) values (@count+1,@pcod,@scod,@ccod,@ucod,@ucena,@odate,@oplStatusCod) 
GO
ALTER TABLE [dbo].[oplata] ENABLE TRIGGER [oplata_id]
GO
/****** Object:  Trigger [dbo].[pet_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[pet_id]
on [dbo].[pet] instead of insert as 
declare @count int, @pnam nvarchar(50),@pvozrast int,@pvid nvarchar(50),@pprotiv nvarchar(200),@posoben nvarchar(200),@ccod int, @pcod int

select @pcod = COUNT(pcod) from pet

if(@pcod=0)
begin
select @count = 0
end
else
begin
select @count=max(pcod) from pet
end

select @pnam=ins.pnam, @pvozrast=ins.pvozrast,@pvid=ins.pvid,@pprotiv=ins.pprotiv,@posoben = ins.posoben,@ccod=ins.ccod from inserted ins 
insert into pet(pcod,pnam,pvozrast,pvid,pprotiv,posoben,ccod) values (@count+1,@pnam,@pvozrast,@pvid,@pprotiv,@posoben,@ccod)
GO
ALTER TABLE [dbo].[pet] ENABLE TRIGGER [pet_id]
GO
/****** Object:  Trigger [dbo].[sotr_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[sotr_id]
on [dbo].[sotr] instead of insert as 
declare @count int, @snam nvarchar(50),@sfam nvarchar(50),@sotch nvarchar(50),@stel nvarchar(50),@dcod int, @slogin nvarchar(50),@spass nvarchar(50), @scod int

select @scod = COUNT(scod) from sotr

if(@scod=0)
begin
select @count = 0
end
else
begin
select @count=max(scod) from sotr
end

select @snam=ins.snam, @sfam=ins.sfam,@sotch=ins.sotch,@stel=ins.stel,@dcod=ins.dcod,@slogin=ins.slogin,@spass=ins.spass from inserted ins 
insert into sotr(scod,snam,sfam,sotch,stel,dcod,slogin,spass) values (@count+1,@snam,@sfam,@sotch,@stel,@dcod,@slogin,@spass) 
GO
ALTER TABLE [dbo].[sotr] ENABLE TRIGGER [sotr_id]
GO
/****** Object:  Trigger [dbo].[uslugi_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[uslugi_id]
on [dbo].[uslugi] instead of insert as 
declare @count int, @unam nvarchar(50),@ucena nvarchar(50), @ucod int

select @ucod = COUNT(ucod) from uslugi

if(@ucod=0)
begin
select @count = 0
end
else
begin
select @count=max(ucod) from uslugi
end

select @unam=ins.unam, @ucena=ins.ucena from inserted ins 
insert into uslugi(ucod,unam,ucena) values (@count+1,@unam,@ucena) 
GO
ALTER TABLE [dbo].[uslugi] ENABLE TRIGGER [uslugi_id]
GO
/****** Object:  Trigger [dbo].[update_bcount]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[update_bcount]
ON [dbo].[zapic]
AFTER INSERT
AS
BEGIN
    UPDATE bolezn
    SET bcount = bcount + 1
    WHERE bcod = (SELECT bcod FROM inserted)
END
GO
ALTER TABLE [dbo].[zapic] ENABLE TRIGGER [update_bcount]
GO
/****** Object:  Trigger [dbo].[zapic_id]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[zapic_id]
on [dbo].[zapic] instead of insert as 
declare @count int, @ccod int,@pcod int,@scod int,@zdate datetime,@statusCod int, @bcod int, @dcod int, @ucod int, @zcod int

select @zcod = COUNT(zcod) from zapic

if(@zcod=0)
begin
select @count = 0
end
else
begin
select @count=max(zcod) from zapic
end

select @ccod=ins.ccod, @pcod=ins.pcod,@scod=ins.scod,@zdate=ins.zdate,@statusCod=ins.statusCod,@bcod=ins.bcod, @dcod = ins.dcod, @ucod = ins.ucod from inserted ins 
insert into zapic(zcod,ccod,pcod,scod,zdate,statusCod,bcod, dcod, ucod) values (@count+1,@ccod,@pcod,@scod,@zdate,@statusCod,@bcod, @dcod, @ucod)
GO
ALTER TABLE [dbo].[zapic] ENABLE TRIGGER [zapic_id]
GO
/****** Object:  Trigger [dbo].[zapic_status_update]    Script Date: 30.01.2023 17:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[zapic_status_update]
ON [dbo].[zapic]
AFTER UPDATE
AS
BEGIN
    IF UPDATE(statusCod) AND EXISTS(SELECT 1 FROM inserted WHERE statusCod = 2)
    BEGIN
        INSERT INTO oplata (pcod, scod, ccod, ucod, ucena, odate, oplStatusCod)
        SELECT z.pcod, z.scod, z.ccod, z.ucod, u.ucena, GETDATE(), 1
        FROM inserted z 
        JOIN uslugi u ON u.ucod = z.ucod
    END
END
GO
ALTER TABLE [dbo].[zapic] ENABLE TRIGGER [zapic_status_update]
GO
