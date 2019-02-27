CREATE TABLE [dbo].[Students] (
    [StudentID]             INT            IDENTITY (1, 1) NOT NULL,
    [StudentName]           NVARCHAR (MAX) NOT NULL,
    [StudentSurname]        NVARCHAR (MAX) NOT NULL,
    [StudentNationalNumber] NVARCHAR (MAX) NOT NULL,
    [StudentEmail]          NVARCHAR (MAX) NOT NULL,
    [StudentBirthdate]      DATETIME       NOT NULL,
    [RegistrationTime]      DATETIME       NOT NULL,
    [RegistrationSeason]    INT            NOT NULL,
    [StudentDebt]           FLOAT (53)     NOT NULL,
    [QuantityInstallment]   INT            NOT NULL,
    [StudentPlaceofBirth]   NVARCHAR (MAX) NOT NULL,
    [StudentPhoneNumber]    NVARCHAR (MAX) NOT NULL,
    [StudentAdress]         NVARCHAR (MAX) NOT NULL,
    [StudentIbanNumber]     NVARCHAR (MAX) NOT NULL,
    [StudentHaveLicence] BIT NULL, 
    [StudentHaveLicenceType] CHAR(10) NULL, 
    [StudentWantLicenceType] CHAR(10) NOT NULL, 
    CONSTRAINT [PK_dbo.Students] PRIMARY KEY CLUSTERED ([StudentID] ASC),
    FOREIGN KEY ([RegistrationSeason]) REFERENCES [dbo].[RegistrationSeasons] ([RegistrationSeasonID])
);

