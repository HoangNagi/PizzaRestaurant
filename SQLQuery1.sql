alter table CHITIETPHIEU
add constraint fk_CTP_MaPhieu 
foreign key (MaPhieu)
references PHIEUDATCHO (MaPhieu)

alter table CHITIETPHIEU
add constraint fk_CTP_MaMonAn
foreign key (MaMonAn)
references MONAN (MaMonAn)

alter table MONAN
add constraint fk_MA_MaDMMonAn
foreign key (MaDMMonAn)
references DANHMUCMONAN (MaDMMonAn)

alter table NHANVIEN
add constraint fk_NV_MaChucVu
foreign key (MaChucVu)
references CHUCVU (MaChucVu)

alter table NHANVIEN
add constraint fk_NV_BacLuong
foreign key (BacLuong)
references LUONG (BacLuong)

alter table PHIEUDATCHO
add constraint fk_PDC_MaNhanVien
foreign key (MaNhanVien)
references NHANVIEN (MaNhanVien)

alter table PHIEUDATCHO
add constraint fk_PDC_MaTinhTrangPhieu
foreign key (MaTinhTrangPhieu)
references TINHTRANGPHIEU (MaTinhTrangPhieu)

alter table PHIEUDATCHO
add constraint fk_PDC_MaBanAn
foreign key (MaBanAn)
references BANAN (MaBanAn)

alter table PHIEUDATCHO
add constraint fk_PDC_MaKhach
foreign key (MaKhach)
references KHACHHANG (MaKhach)

alter table NGUOIDUNG
add constraint fk_ND_MaNhanVien
foreign key (MaNhanVien)
references NHANVIEN (MaNhanVien)


