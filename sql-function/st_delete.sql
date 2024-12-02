CREATE OR REPLACE FUNCTION st_delete (_id_karyawan INT)
RETURNS INT AS $$
BEGIN
	DELETE FROM karyawan
	WHERE
	id_karyawan = _id_karyawan;
	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END
$$ LANGUAGE plpgsql;
