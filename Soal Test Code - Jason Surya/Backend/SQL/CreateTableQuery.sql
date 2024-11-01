USE MegaCentralFinanceTest

-- CREATE TABLE ms_storage_location
CREATE TABLE ms_storage_location(
	location_id VARCHAR(10) PRIMARY KEY,
	location_name VARCHAR(100)
);

-- CREATE TABLE ms_user
CREATE TABLE ms_user(
	user_id BIGINT PRIMARY KEY,
	user_name VARCHAR(20),
	password VARCHAR(50),
	is_active BIT 
);

-- CREATE TABLE tr_bpkb
CREATE TABLE tr_bpkb(
	agreement_number VARCHAR(100) PRIMARY KEY,
	bpkb_no VARCHAR(100),
	branch_id VARCHAR(10),
	bpkb_date DATETIME,
	faktur_no VARCHAR(100),
	faktur_date DATETIME,
	location_id VARCHAR(10),
	police_no VARCHAR(20),
	bpkb_date_in DATETIME,
	created_by VARCHAR(20),
	created_on DATETIME,
	last_updated_by VARCHAR(20),
	last_updated_on DATETIME
	CONSTRAINT FK_locationID FOREIGN KEY (location_id)
	REFERENCES ms_storage_location(location_id)
);