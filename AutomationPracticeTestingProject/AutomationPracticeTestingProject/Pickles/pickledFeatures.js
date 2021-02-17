jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "BDD\\Features\\AP_CreateAccount.feature",
      "Feature": {
        "Name": "AP_AccountCreate",
        "Description": "As a user I want to be able to create an account so that I can view my account information",
        "FeatureElements": [
          {
            "Examples": [],
            "Name": "Invalid email address",
            "Slug": "invalid-email-address",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the SigninPage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter an email \"test\"",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result I should see an alert with a message \"Invalid email address.\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@CreateAccount"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Examples": [],
            "Name": "Create account page",
            "Slug": "create-account-page",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the SigninPage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter an email",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see \"CREATE AN ACCOUNT\" page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@CreateAccount"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Examples": [],
            "Name": "My account page",
            "Slug": "my-account-page",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the SigninPage",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter an email",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I populate the required fields",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I click register",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see \"MY ACCOUNT\" page",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@CreateAccount"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true,
          "WasProvided": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true,
        "WasProvided": true
      }
    },
    {
      "RelativeFolder": "BDD\\Features\\AP_Dresses.feature",
      "Feature": {
        "Name": "AP_Dresses",
        "Description": "As a user I want to be able to visit the dresses page so that I can view or buy my preferred clothes",
        "FeatureElements": [
          {
            "Examples": [],
            "Name": "PopUp Visible",
            "Slug": "popup-visible",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the dresses page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add 1 product to cart",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see a PopUp confirmation",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Dresses"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Examples": [],
            "Name": "Continue shopping",
            "Slug": "continue-shopping",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the dresses page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add 1 product to cart",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I click continue shopping on the PopUp",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the dressespage with the title \"Dresses - My Store\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Dresses"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Examples": [],
            "Name": "Buy 1 products",
            "Slug": "buy-1-products",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the dresses page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I add 1 product to cart",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I click proceed to checkout on the PopUp",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see the total price \"$52.99\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Dresses"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true,
          "WasProvided": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true,
        "WasProvided": true
      }
    },
    {
      "RelativeFolder": "BDD\\Features\\Signin.feature",
      "Feature": {
        "Name": "AP_Signin",
        "Description": "Provides the user with the ability to sign in by entering their email and password",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "email",
                    "password"
                  ],
                  "DataRows": [
                    [
                      "testingemail@gmail.com",
                      "1234",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true,
                        "WasProvided": true
                      }
                    ],
                    [
                      "testingemail@gmail.com",
                      "wiz",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true,
                        "WasProvided": true
                      }
                    ],
                    [
                      "testingemail@gmail.com",
                      "sick",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true,
                        "WasProvided": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Password too short",
            "Slug": "password-too-short",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the signin page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have entered an  <email> and a <password>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click the sign in button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see an alert containing the error message \"Invalid password\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Signin"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "email",
                    "password"
                  ],
                  "DataRows": [
                    [
                      "hi",
                      "Password123!",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true,
                        "WasProvided": true
                      }
                    ],
                    [
                      "bye",
                      "Password123!",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true,
                        "WasProvided": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Invalid email",
            "Slug": "invalid-email",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the signin page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have entered an  <email> and a <password>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click the sign in button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see an alert containing the error message \"Invalid email address\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Signin"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "email",
                    "password"
                  ],
                  "DataRows": [
                    [
                      "testingemail@gmail.com",
                      "Password123!",
                      {
                        "WasExecuted": true,
                        "WasSuccessful": true,
                        "WasProvided": true
                      }
                    ]
                  ]
                },
                "Tags": [],
                "NativeKeyword": "Examples"
              }
            ],
            "Name": "Access account page",
            "Slug": "access-account-page",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I am on the signin page",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have entered an  <email> and a <password>",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click the sign in button",
                "StepComments": [],
                "AfterLastStepComments": []
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I should see a page with the title \"My account - My Store\"",
                "StepComments": [],
                "AfterLastStepComments": []
              }
            ],
            "Tags": [
              "@Signin"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true,
              "WasProvided": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true,
          "WasProvided": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true,
        "WasProvided": true
      }
    }
  ],
  "Summary": {
    "Tags": [
      {
        "Tag": "@CreateAccount",
        "Total": 3,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@Dresses",
        "Total": 3,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      },
      {
        "Tag": "@Signin",
        "Total": 3,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Folders": [
      {
        "Folder": "BDD",
        "Total": 9,
        "Passing": 3,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "NotTestedFolders": [
      {
        "Folder": "BDD",
        "Total": 0,
        "Passing": 0,
        "Failing": 0,
        "Inconclusive": 0
      }
    ],
    "Scenarios": {
      "Total": 9,
      "Passing": 9,
      "Failing": 0,
      "Inconclusive": 0
    },
    "Features": {
      "Total": 3,
      "Passing": 3,
      "Failing": 0,
      "Inconclusive": 0
    },
    "FoldersWithTestKinds": [
      {
        "Folder": "BDD",
        "Total": 9,
        "Automated": 9,
        "Manual": 0,
        "NotTested": 0
      }
    ]
  },
  "Configuration": {
    "SutName": "AutomationPracticeWebTests",
    "SutVersion": "v1.0",
    "GeneratedOn": "17 February 2021 11:44:47"
  }
});