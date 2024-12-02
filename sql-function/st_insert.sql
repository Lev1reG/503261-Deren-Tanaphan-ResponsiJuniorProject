CREATE FUNCTION st_insert (_nama VARCHAR, _id_dep VARCHAR, _id_jabatan int)
RETURNS INT AS $$
BEGIN
	INSERT INTO karyawan (nama, id_dep, id_jabatan)
	VALUES (_nama, _id_dep, _id_jabatan);
	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END
$$ LANGUAGE plpgsql;
