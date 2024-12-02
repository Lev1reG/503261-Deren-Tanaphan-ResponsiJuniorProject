CREATE OR REPLACE FUNCTION st_select()
RETURNS TABLE(
id_karyawan INT,
Nama VARCHAR,
Departemen VARCHAR,
Jabatan VARCHAR,
salary NUMERIC
) AS $$
BEGIN
	RETURN QUERY 
	SELECT 
	karyawan.id_karyawan,
	karyawan.nama as Nama,
	departemen.nama_dep AS Departemen,
	jabatan.nama as Jabatan,
	jabatan.salary_number as Salary
	FROM karyawan
	INNER JOIN
	departemen ON karyawan.id_dep = departemen.id_dep
	INNER JOIN
	jabatan ON karyawan.id_jabatan = jabatan.id_jabatan;
END
$$ LANGUAGE plpgsql;