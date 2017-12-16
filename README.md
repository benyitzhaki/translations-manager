# translations-manager
manage translations that will be categorized by project, category, language, key

This service will (hopefully when done) expose an API that will enable you to manage your translations. 
UI is not part of the current plans. 

## exptected structure in mongodb:
```
{"projects" : {
    "appmodules" : 
        {
            "Categories" : [],
            "Languages" : [],
            "LangKeys" : { "en" => {"LangKey" => "KeyValue"} }
        }
  }
}
```
# TODO (by priority):
 - create interfaces
 - create mongodb connection
 - create models
 - create controllers
 - add swagger ui
 - consider seperating dal to a seperate project
 - dockerize mongodb
 - dockerzie project