CREATE DATABASE CaoThiThanhXuan_231230966_de01
USE CaoThiThanhXuan_231230966_de01

CREATE TABLE CaoThiThanhXuanComputer(
	CaoThiThanhXuanComId INT IDENTITY(1,1) PRIMARY KEY,
	CaoThiThanhXuanComName NVARCHAR(100) NOT NULL,
	CaoThiThanhXuanComPrice DECIMAL(12,2) CHECK (CaoThiThanhXuanComPrice BETWEEN 100 AND 5000),
	CaoThiThanhXuanComImage NVARCHAR(200) CHECK(
		CaoThiThanhXuanComImage LIKE '%.jpg' OR
		CaoThiThanhXuanComImage LIKE '%.png' OR
		CaoThiThanhXuanComImage LIKE '%.gif'
	),
	CaoThiThanhXuanComStatus BIT NOT NULL
);

INSERT INTO CaoThiThanhXuanComputer(CaoThiThanhXuanComName, CaoThiThanhXuanComPrice, CaoThiThanhXuanComImage, CaoThiThanhXuanComStatus)
VALUES
(N'DELL', 1500, 'dell.jpg', 1),
(N'HP', 1200, 'hp.png', 0),
(N'ASUS', 2500, 'asus.gif', 1);