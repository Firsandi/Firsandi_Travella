select * from guides
ALTER TABLE paket_trips ADD COLUMN guide_id INT;
ALTER TABLE paket_trips ADD CONSTRAINT fk_guide FOREIGN KEY (guide_id) REFERENCES guides(guide_id);
ALTER TABLE guides DROP COLUMN pengalaman;

