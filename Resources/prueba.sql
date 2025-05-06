INSERT into Users (Username, Password, Email) VALUES
('admin', 'admin123', 'admin@example.com'),
('user1', 'user123', 'user1@example.com');

-- Insertar Roles
INSERT INTO Roles(RoleName, "Descripction") VALUES
('Admin', 'Administrator role'),
('User', 'Regular user role');
-- Insertar UserRoles
INSERT INTO UserRoles ( UserID, RolesID) VALUES
( 1,1),
( 2,2);


-- Insertar Procedures
INSERT INTO "Procedures" (ProcedureName, "Description", CreatedByUserID, CreatedDate, LastModifiedUserId, LastModifiedDate) VALUES
('Data Cleaning', 'Removes duplicates and standardizes formats', 1, GETDATE(), 1, GETDATE()),
('Statistical Analysis', 'Performs basic statistical calculations', 1, GETDATE(), 1, GETDATE()),
('Data Visualization', 'Creates charts and graphs from data', 2, GETDATE(), 2, GETDATE()),
('Machine Learning Model', 'Trains and applies ML models to data', 1, GETDATE(), 2, GETDATE()),
('Data Integration', 'Merges data from multiple sources', 2, GETDATE(), 1, GETDATE());

-- Insertar Fields
INSERT INTO Fields ( FieldName, DataType) VALUES
('SampleField1', 'varchar'),
('SampleField2', 'int');

-- Insertar DataSets
INSERT INTO DataSets ( DataSetName, Description, ProcedureID, FieldId, CreatedDate, LastModifiedDate) VALUES
('Sales Data 2023', 'Annual sales figures', 1, 1, GETDATE(), GETDATE()),
('Customer Feedback', 'Survey responses from Q2', 2, 2, GETDATE(), GETDATE()),
('Website Traffic', 'Daily visitor counts', 3, 2, GETDATE(), GETDATE()),
('Product Inventory', 'Current stock levels', 1, 2, GETDATE(), GETDATE()),
('Employee Performance', 'Quarterly KPI data', 2, 1, GETDATE(), GETDATE()),
('Marketing Campaign Results', 'ROI for recent campaigns', 3, 1, GETDATE(), GETDATE()),
('Supply Chain Data', 'Supplier delivery times', 4, 2, GETDATE(), GETDATE()),
('Customer Segmentation', 'Demographic clusters', 4, 2, GETDATE(), GETDATE()),
('Social Media Metrics', 'Engagement rates across platforms', 3, 1, GETDATE(), GETDATE()),
('Financial Forecasts', 'Projected revenue for next FY', 2, 1, GETDATE(), GETDATE()),
('Product Returns', 'Reasons for customer returns', 1, 1, GETDATE(), GETDATE()),
('Website Heatmaps', 'User interaction patterns', 3, 2, GETDATE(), GETDATE()),
('Customer Churn Prediction', 'ML model input data', 4, 2, GETDATE(), GETDATE()),
('Competitor Price Analysis', 'Market rate comparisons', 2, 2, GETDATE(), GETDATE()),
('IoT Sensor Data', 'Raw data from factory sensors', 5, 2, GETDATE(), GETDATE());