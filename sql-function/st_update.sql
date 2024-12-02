CREATE OR REPLACE FUNCTION st_update (_id_karyawan INT, _nama VARCHAR, _id_dep VARCHAR, _id_jabatan int)
RETURNS INT AS $$
BEGIN
	UPDATE karyawan
	SET nama = _nama, id_dep = _id_dep, id_jabatan = _id_jabatan
	WHERE id_karyawan = _id_karyawan;
	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END
$$ LANGUAGE plpgsql;
