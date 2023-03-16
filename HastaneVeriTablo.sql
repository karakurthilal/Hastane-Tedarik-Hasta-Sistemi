create table patient( hid INTEGER,
				      hname CHAR(30),
				      kilac CHAR(15),
				      kcihaz CHAR(20),
				   PRIMARY KEY(hid) )
create table part(bid CHAR(5),
				  bname CHAR(30),
				  bilac INTEGER,
				  bcihaz INTEGER,
				  PRIMARY KEY(bid) )
create table supplier(tid char(7),
					  tname char(15),
					  tadress char(100),
					  ttel INTEGER,
				      PRIMARY KEY (tid) )
create table device(seriNo CHAR(13),
				   cname CHAR(30),
				   PRIMARY KEY(seriNo) )
create table consumableDevice(sseriNo CHAR(13),
					          scname CHAR(30),
					          PRIMARY KEY(sseriNo) )
create table medicine(barkod CHAR(13),
				      iname CHAR(30),
				      PRIMARY KEY (barkod) )
create table consumableMedicine(sbarkod CHAR (13),
					  siname CHAR(30),
					  PRIMARY KEY (sbarkod) )
create table hospital(bid CHAR(5),
					 hid INTEGER,
					 tid CHAR(7),
					 seriNo CHAR(13),
					 sseriNo CHAR (13),
					 barkod CHAR(13),
					 sbarkod CHAR(13),
					 haname CHAR(20),
					 PRIMARY KEY (bid , hid, tid ),
					 FOREIGN KEY (bid) REFERENCES  part,
					 FOREIGN KEY (hid) REFERENCES  patient,
					 FOREIGN KEY (tid) REFERENCES  supplier )
create table production(seriNo char(13),
					    sseriNo char(13),
					    barkod char(13),
					    sbarkod char(13),
						tid CHAR(7),
					    PRIMARY KEY (tid, seriNo, sseriNo, barkod, sbarkod),
						FOREIGN KEY (tid) REFERENCES  supplier,
					    FOREIGN KEY (seriNo) REFERENCES device,
				 	    FOREIGN KEY (sseriNO) REFERENCES consumableDevice,
					    FOREIGN KEY (barkod) REFERENCES medicine,
					    FOREIGN KEY (sbarkod) REFERENCES consumableMedicine )