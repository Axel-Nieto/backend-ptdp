USE master;
GO
IF DB_ID (N'taproyectoTallerll') IS NOT NULL
DROP DATABASE proyectoTaller;
GO
CREATE DATABASE proyectoTaller;
GO
-- Verify the database files and sizes
SELECT name, size, size*1.0/128 AS [Size in MBs]
FROM sys.master_files
WHERE name = N'proyectoTaller';
GO
