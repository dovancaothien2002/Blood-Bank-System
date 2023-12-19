use DataSem3;

Insert into Account(Name,UserName,Email,Password) values (N'Nguyễn Văn Anh','anh123','admin@gmail.com','123456')

Insert into Blood(bloodName,create_at,update_at) values (N'A-','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'A+','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'B-','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'B+','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'AB-','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'AB+','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'O-','2023-1-17','2023-1-17')
Insert into Blood(bloodName,create_at,update_at) values (N'O+','2023-1-17','2023-1-17')

Insert into City(cityName,create_at,update_at) values (N'Ha Noi','2023-1-17','2023-1-17')
Insert into City(cityName,create_at,update_at) values (N'Da Nang','2023-1-17','2023-1-17')
Insert into City(cityName,create_at,update_at) values (N'Ho Chi Minh','2023-1-17','2023-1-17')

Insert into District(cityId,districtName,create_at,update_at) values (1,N'Dong Da','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (1,N'Cau Giay','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (1,N'Hoang Mai','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (1,N'Hoan Kiem','2023-1-17','2023-1-17')

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Bao Son General Hospital ',1,'8am-6pm, Open every day','52 Nguyen Chi Thanh, Lang Ha','0932804943','baoson@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Ha Thanh Private General Hospital ',1,'8am-5:30pm, Monday to Friday','61 Vu Thanh','0990201283','hathanh@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Dong Do Hospital Joint Stock Company ',1,'8am-6pm, Open every day','5 Xa Đan','0909071143','dongdo@gmail.com','123456','2023-1-17','2023-1-17') 

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Thu Cuc International Hospital ',2,'8am-5:30pm, Monday to Friday','216 Tran Duy Hung, Trung Hoa','0909702812','thucuc@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Yen Hoa Private General Hospital ',2,'8am-5:30pm, Monday to Friday','61 Vũ Thạnh','0902389446','yenhoa@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Cau Giay International Hospital ',2,'8am-6pm, Open every day','59 Thong Phong, Ton Đuc Thang','0932804943','trangan@gmail.com','123456','2023-1-17','2023-1-17')

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Linh Nam Private General Hospital ',3,'8am-6pm, Open every day','Linh Nam','0937283723','linhnam@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Linh Dam Private General Hospital ',3,'8am-6pm, Open every day','Linh Dam','0900434958','linhdam@gmail.com','123456','2023-1-17','2023-1-17') 

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Luong Ngoc Quyen General Hospital ',4,'8am-6pm, Open every day','26 Luong Ngoc Quyen','0932804943','luongngocquyen@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Phan Chu Trinh Private General Hospital ',4,'8am-5:30pm, Monday to Friday','21 Phan Chu Trinh','0990201283','phanchutrinh@gmail.com','123456','2023-1-17','2023-1-17') 

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,1,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,2,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,3,4000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,4,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,5,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,7,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (1,8,5000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (2,3,4000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (2,1,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (2,7,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (3,1,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (3,2,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (3,4,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (3,5,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (3,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (3,8,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (4,1,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (4,2,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (4,4,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (4,5,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (4,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (4,7,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (5,4,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (5,5,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (5,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (5,7,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (6,1,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (6,5,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (6,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (6,8,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,1,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,2,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,4,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,7,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (7,8,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (8,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (8,4,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (8,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (8,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (8,7,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (8,8,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (9,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (9,7,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (9,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (9,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (9,4,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (10,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (10,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (10,7,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (10,8,2500,'2023-1-17','2023-1-17')

Insert into District(cityId,districtName,create_at,update_at) values (2,N'Hai Chau','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (2,N'Thanh Khe','2023-1-17','2023-1-17')

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'C Da Nang Hospital ',5,'8am-6pm, Open every day','122 Hai Chau','0900568934','cdanang@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Military Hospital 17 - Logistics Department of Military Region V',5,'8am-5:30pm, Monday to Friday','02 Nguyen Huu Tho','0918567856','quany17@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Hospital 199 - Ministry of Public Security',5,'8am-6pm, Open every day','216 Nguyen Cong Tru','0909071143','congan199@gmail.com','123456','2023-1-17','2023-1-17') 

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Thanh Khe International Hospital ',6,'8am-5:30pm, Monday to Friday','525 Tong Duc Thang','0909702812','thanhkhe@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Nam Lien Chieu General Hospital ',6,'8am-5:30pm, Monday to Friday','68 Hoang Van Thai','0902389446','namlucchieu@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Hoa Vang International Hospital ',6,'8am-6pm, Open every day','Thach Nam, Hoa Nhon','0932804943','hoavang@gmail.com','123456','2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (11,1,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (11,2,6000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (11,4,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (11,5,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (11,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (11,7,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (12,1,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (12,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (12,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (12,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (12,7,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (13,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (13,7,2500,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (14,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (14,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (14,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (14,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (14,7,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (15,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (15,7,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (15,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (15,3,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (16,1,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (16,2,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (16,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (16,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (16,7,3000,'2023-1-17','2023-1-17')

Insert into District(cityId,districtName,create_at,update_at) values (3,N'Binh Thanh','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (3,N'Tan Binh','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (3,N'Quan 5','2023-1-17','2023-1-17')
Insert into District(cityId,districtName,create_at,update_at) values (3,N'Quan 8','2023-1-17','2023-1-17')

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Nguyen Trai International Hospital ',7,'8am-5:30pm, Monday to Friday','314 Nguyen Trai','0909702812','nguyentrai@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Nguyen Tri Phuong General Hospital ',7,'8am-5:30pm, Monday to Friday','468 Nguyen Trai','0902389446','nguyentriphuong@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Trung Vuong International Hospital ',7,'8am-6pm, Open every day','266 Ly Thuong Kiet','0932804943','trungvuong@gmail.com','123456','2023-1-17','2023-1-17')

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'An Binh Hospital ',8,'8am-5:30pm, Monday to Friday','147 An Binh','0909702812','anbinh@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Sai Gon General Hospital ',8,'8am-5:30pm, Monday to Friday','125 Le Loi, Ben Thanh','0902389446','saigon@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'7A Hospital ',8,'8am-6pm, Open every day','488 Nguyen Trai','0932804943','a7@gmail.com','123456','2023-1-17','2023-1-17')

Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Hong Duc General Hospital - Branch III',9,'8am-5:30pm, Monday to Friday','32/2 Thong Nhat','0909702812','hongduc@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Vinmec Central Park International General Hospitall',9,'8am-5:30pm, Monday to Friday','720A Đien Bien Phu','0902389446','vinmec@gmail.com','123456','2023-1-17','2023-1-17') 
Insert into BloodBank(bbName,districtId,calendar,address,hotline,email,password,create_at,update_at) values (N'Cu Chi International Hospital ',9,'8am-6pm, Open every day','An Hoi, Cu Chi','0932804943','cuchi@gmail.com','123456','2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (17,1,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (17,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (17,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (17,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (17,2,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (18,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (18,7,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (18,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (18,3,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (19,1,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (19,2,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (19,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (19,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (19,7,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (20,4,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (20,3,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (20,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (20,8,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (20,2,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (21,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (21,7,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (21,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (21,3,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (22,1,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (22,2,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (22,4,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (22,5,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (22,6,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (23,7,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (23,1,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (23,2,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (23,3,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (23,4,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (24,6,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (24,7,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (24,5,2000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (24,3,3000,'2023-1-17','2023-1-17')

Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (25,7,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (25,2,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (25,4,3000,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (25,5,2500,'2023-1-17','2023-1-17')
Insert into BloodStock(bbId,bloodId,quantity,create_at,update_at) values (25,6,3000,'2023-1-17','2023-1-17')

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Le Duc Hai',N'170/14 Cao Lo',28,'1995-12-29',1,1,'duchai@gmail.com','0929398912','123456','2023-1-17','2023-1-17',60,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Le Hoang Son',N'615 KP2, Ton Lua',24,'1999-01-03',1,1,'hoangson@gmail.com','0901623533','123456','2023-1-17','2023-1-17',55,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Pham Thi Truc Vy',N'6 Huy Tran Lieu',24,'1999-01-03',1,2,'trucvy@gmail.com','0982374844','123456','2023-1-17','2023-1-17',57,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Truong Thi Minh',N'19 8A Street',21,'2002-06-12',1,3,'thiminh@gmail.com','0929398912','123456','2023-1-17','2023-1-17',60,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Tran Thi Anh Nguyet',N'265 Duong Dinh Hoi',23,'2000-03-03',1,4,'anhnguyet@gmail.com','0901623533','123456','2023-1-17','2023-1-17',55,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Le Tuan Kiet',N'128/4 Hiep Thanh',18,'2003-11-05',1,7,'tuankiet@gmail.com','0982374844','123456','2023-1-17','2023-1-17',69,1,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Pham Thi Xoa',N'274 Ngo Quyen',24,'1999-12-22',2,8,'thixoa123@gmail.com','0929398912','123456','2023-1-17','2023-1-17',55,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Nguyen Doan Quan',N'Hoang Linh, Binh Hung',34,'1989-11-08',2,6,'doanquan@gmail.com','0901623533','123456','2023-1-17','2023-1-17',59,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Vo Thi Thi',N'6 Huy Tran Lieu',24,'1999-02-11',2,2,'thithi@gmail.com','0982374844','123456','2023-1-17','2023-1-17',57,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Tran Anh Tuan',N'269A Tan Huong, Tan Quy',21,'2002-06-12',2,2,'anhtuan123@gmail.com','0929398912','123456','2023-1-17','2023-1-17',61,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Ha Thi Thuy Ngoc',N'11888 Pham The Hien',23,'2000-06-13',2,4,'thuyngoc@gmail.com','0901623533','123456','2023-1-17','2023-1-17',59,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Ton That Phong',N'17 Tan Hung Thuan',19,'2003-05-05',2,1,'thatphong@gmail.com','0982374844','123456','2023-1-17','2023-1-17',62,1,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Huynh Chieu Hoang',N'108B Le Van Sy',24,'1999-12-22',3,1,'chieuhoang@gmail.com','0929398912','123456','2023-1-17','2023-1-17',55,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Diep Van Quan',N'140 Tran Dai Nghia',45,'1988-11-08',3,6,'vanquan321@gmail.com','0901623533','123456','2023-1-17','2023-1-17',59,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Tran Mong Thi',N'A12 KP5',25,'1998-02-11',3,3,'mongthi@gmail.com','0982374844','123456','2023-1-17','2023-1-17',52,0,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Chu Kim Giao',N'125 Dang Van Ngu',21,'2002-06-12',4,8,'kimgiao@gmail.com','0929398912','123456','2023-1-17','2023-1-17',50,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Le Thi Lan Phuong',N'P15 Pham Hung',23,'2000-06-13',4,4,'lanphuong13@gmail.com','0901623533','123456','2023-1-17','2023-1-17',59,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Nguyen Van Le',N'3x Hung Long',19,'2003-05-05',4,5,'vanle55@gmail.com','0982374844','123456','2023-1-17','2023-1-17',62,1,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Nguyen Thi Thu Van',N'Sky Garden Tan Phong',54,'1979-12-22',5,4,'thuvan99@gmail.com','0929398912','123456','2023-1-17','2023-1-17',55,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Nguyen Thi Thu Cuc',N'2Q Binh Hung',31,'1992-11-08',5,1,'thucuc321@gmail.com','0901623533','123456','2023-1-17','2023-1-17',50,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Dong Thi Kim Ngan',N'BHH B',24,'1999-02-11',5,3,'kimngan@gmail.com','0982374844','123456','2023-1-17','2023-1-17',52,0,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Le Thi Lan',N'P30 Tan Tho P08',21,'2002-06-12',6,8,'thilan02@gmail.com','0929398912','123456','2023-1-17','2023-1-17',50,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Dang Thi Tien',N'P22 Tan Xuan',23,'2000-06-13',6,4,'thitien@gmail.com','0901623533','123456','2023-1-17','2023-1-17',64,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Ngo Thanh Son',N'Duong Dinh Hoi Le BC',19,'2003-05-05',6,1,'thanhhuong@gmail.com','0982374844','123456','2023-1-17','2023-1-17',62,1,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Ngo Thanh Son',N'86 Duong Dinh Hoi, KP6',54,'1979-12-22',7,4,'thanhson88@gmail.com','0929398912','123456','2023-1-17','2023-1-17',55,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Nguyen Van Dung',N'Phan Van Hon KP5 Tan Hoi Nhat',31,'1992-11-08',7,1,'vandung@gmail.com','0901623533','123456','2023-1-17','2023-1-17',50,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Do Van Cuong',N'Tan Hoi Hiep 21',24,'1999-02-11',7,3,'vancuong88@gmail.com','0982374844','123456','2023-1-17','2023-1-17',52,1,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Le Thi Thanh Van',N'37 Dang Van Ngu',21,'2002-06-12',8,8,'thanhvan12@gmail.com','0929398912','123456','2023-1-17','2023-1-17',50,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Tran Minh Ut',N'Ha Huy Giap, Thanh Loc',23,'2000-06-13',8,3,'minhut@gmail.com','0901623533','123456','2023-1-17','2023-1-17',64,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Bui Thi Hanh',N'03 Tan Dao P08',19,'2003-05-05',8,5,'thihanh08@gmail.com','0982374844','123456','2023-1-17','2023-1-17',62,1,1)

insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Truong Thi Bich My',N'44 Bui Minh Truc',21,'2002-06-12',9,1,'bichmy@gmail.com','0929398912','123456','2023-1-17','2023-1-17',50,0,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Tran Duc Dung',N'Ha Huy Giap, Thanh Loc',24,'2000-06-13',9,6,'ducdung@gmail.com','0901623533','123456','2023-1-17','2023-1-17',62,1,1)
insert into Donor(donorName,address,age,birthday,districtId,bloodId,email,phone,password,create_at,update_at,weight,gender,status) VALUES (N'Vo Thi Kim Loan',N'58 Nguyen Son, Phu Tho Hoa',19,'2003-05-05',9,5,'kimloan@gmail.com','0982374844','123456','2023-1-17','2023-1-17',51,0,1)





