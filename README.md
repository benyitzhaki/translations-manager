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
 - inject Settings (create interface)
 - add swagger ui
 - cache?
 - protect api from too many requests etc
 - add authentication (users should be able to implemnet own login so they can use own user directories)
 - dockerize mongodb
 - dockerzie project