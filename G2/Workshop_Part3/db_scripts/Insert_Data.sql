-- Insert Cars
INSERT INTO Cars (Model, LicensePlate, LicensePlateExpieryDate)
VALUES 
('Toyota Corolla', 'SK-1234-AB', '2026-05-10'),
('Ford Focus', 'SK-5678-CD', '2025-12-31'),
('Volkswagen Golf', 'SK-9012-EF', '2024-10-15');

-- Insert Users
INSERT INTO [Users] (Username, [Password], Role)
VALUES
('admin', 'admin123', 0),
('manager1', 'manager123', 1),
('driver1', 'driverpass', 2);

-- Insert Drivers
INSERT INTO Drivers (FirstName, LastName, Shift, License, LicenseExpieryDate, CarId)
VALUES
('John', 'Doe', 0, 'A123456', '2025-08-20', 1),
('Jane', 'Smith', 1, 'B987654', '2026-01-01', 2),
('Alex', 'Johnson', 2, 'C111222', '2024-09-10', 3);