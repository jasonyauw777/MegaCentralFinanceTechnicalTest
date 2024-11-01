USE MegaCentralFinanceTest

-- no 2
SELECT * FROM Pembayaran
WHERE CAST(TglBayar AS Date) = '2014-10-20'

-- no 3
INSERT INTO Cabang 
VALUES ('200', 'Tangerang')

-- no 4
UPDATE Pembayaran 
SET KodeMotor = '001'
FROM Pembayaran 
INNER JOIN Cabang ON Cabang.KodeCabang = Pembayaran.KodeCabang
WHERE Cabang.NamaCabang = 'JAKARTA'

-- no 5
SELECT 
	P.NoKontrak,
	P.TglBayar,
	P.JumlahBayar,
	C.KodeCabang,
	C.NamaCabang,
	P.NoKwintasi,
	M.KodeMotor,
	M.NamaMotor
FROM Pembayaran P
INNER JOIN Cabang C ON C.KodeCabang = P.KodeCabang
INNER JOIN Motor M ON P.KodeMotor = M.KodeMotor

-- no 6
SELECT 
	C.KodeCabang,
	C.NamaCabang,
	P.NoKontrak,
	P.NoKwintasi
FROM Cabang C 
LEFT JOIN Pembayaran P ON P.KodeCabang = C.KodeCabang

-- no 7
SELECT 
	C.KodeCabang,
	C.NamaCabang,
	COUNT(P.KodeCabang) AS TotalData,
	COALESCE(SUM(P.JumlahBayar), 0) AS TotalBayar
FROM Cabang C
LEFT JOIN Pembayaran P ON P.KodeCabang = C.KodeCabang
GROUP BY C.KodeCabang, C.NamaCabang
