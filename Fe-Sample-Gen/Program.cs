using IO.Swagger.Models;

//Task t1 = new Task(() => File.Open("e:\\еее.txt", FileMode.Open, FileAccess.Write));
//Task t2 = new Task(() => File.Open("e:\\еее.txt", FileMode.Open, FileAccess.Write));

//t1.Start();
//t2.Start();

//Task.WaitAll(t1, t2);

var fnsDataCollectionTaskDto = new FnsDataCollectionTaskDto()
{
    Applicant = new ApplicantDto()
    {
        Name = "Налоговая инспекция №1"
    },
    DueDate = new DateTime(2023, 01, 27),
    RegDate = new DateTime(2023, 01, 26),
    RegNumber = "2036",
    CoverLetter = new FnsAnnexDto()
    {
        Parts = new List<FilePartDto>()
        {
            new FilePartDto
            {
                Id = "1006692f-6a68-469d-91eb-a2c29cf3b6de",
                FileStatus = FilePartDto.FileStatusEnum.ACTUALEnum,
                Name = "Сопроводительное(неверный формат).docx"
            }
        }
    },
    Targets = new[]
    {
        new FnsTargetCollectionDto()
        {
            Id = "b606c039-1977-4f9e-abaf-981bc715b9b0",
            TargetType = new DictionaryItem()
            {
                Name= "Юридическое лицо",
                CodeName = "TARGET_COMPANY"
            },
            Inn = "5888095809",
            Name = "ООО \"Источник\"",
            Kpp = "132201233",
            Products= new[]
            {
                new FnsProductCollectionDto()
                {
                    Id = "37e91985-bbdb-484a-a693-e174b1a71d03",
                    ProductType= new DictionaryItem()
                    {
                        CodeName = "PROD_ACCOUNT",
                        Name = "Счет"
                    },
                    Attributes = new List<FnsAttributeCollectionDto>()
                    {
                        new FnsAttributeCollectionDto()
                        {
                            Id = "ec643a16-4513-4b46-b77e-89e4e157494a",
                            AttributeType= new DictionaryItem()
                            {
                                CodeName = "ATTR_ACCOUNT_OPEN_REQUEST",
                                Name = "Копия заявления на открытие (закрытие) счета (код 301*)"
                            },
                            FromDate=new DateTime(2022, 01, 01),
                            ToDate=new DateTime(2022, 06, 01),
                            ObtainedDataStatus = FnsAttributeCollectionDto.ObtainedDataStatusEnum.SUCCESSEnum,
                            FoundProducts = new List<FnsCollectionFoundProductDto>()
                            {
                                new FnsCollectionFoundProductDto()
                                {
                                    Value = "50872432800000003968",
                                    Annexes = new List<FnsAnnexDto>()
                                    {
                                        new FnsAnnexDto(){
                                            FromArchive = false,
                                            Parts = new List<FilePartDto>{ new FilePartDto()
                                            {
                                                FileStatus =  FilePartDto.FileStatusEnum.ACTUALEnum,
                                                Id = "681078a5-7de6-40ae-a8c8-8d0333a4023e",
                                                Name = "Заявление на открытие счета.pdf"
                                            }
                                            }
                                        },                                        
                                        new FnsAnnexDto(){
                                            Parts = new List<FilePartDto>{ new FilePartDto() {
                                                FileStatus =  FilePartDto.FileStatusEnum.ACTUALEnum,
                                                Id = "4c4482e5-9622-43e9-b35a-8df15cf9f507",
                                                Name = "Заявление на открытие счета(невалидный формат).mp3"
                                            } }
                                        },
                                    }
                                },
                                new FnsCollectionFoundProductDto()
                                {
                                    Value = "40750194100000006127",
                                    Annexes = new List<FnsAnnexDto>()
                                    {
                                        new FnsAnnexDto(){
                                            FromArchive = true,
                                            Parts = new List<FilePartDto>{ new FilePartDto() {
                                                FileStatus =  FilePartDto.FileStatusEnum.ACTUALEnum,
                                                Id = "edc850e7-084a-46fc-a94a-b79ae57e7520",
                                                Name = "Заявление на открытие счета.pdf",                                                 
                                            } 
                                            }
                                        }                                        
                                    }
                                },
                            }
                        }
                    }
                }
                ,
                new FnsProductCollectionDto()
                {
                    Id = "9d77acd0-5ddb-471c-9cf0-a8c757e019f4",
                    ProductType= new DictionaryItem()
                    {
                        CodeName = "PROD_ACCOUNT",
                        Name = "Счет"
                    },
                    RejectionReasons = new List<DictionaryItem>(){
                        new DictionaryItem()
                        {
                            Name = "Продукт в банке не открывался",
                            CodeName = "CR_TARGET_NOT_CLIENT"
                        }
                    },
                    ProductValue = "40381763200000002837"
                }
            }.ToList()
        }
    }.ToList()
};

var json = fnsDataCollectionTaskDto.ToJson();
File.WriteAllText(".\\result.json", json);

Console.WriteLine("Press any key");
Console.ReadLine();
