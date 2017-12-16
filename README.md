# translations-manager
manage translations that will be categorized by project, category, language, key

##exptected structure in mongodb:
```{"projects" : {
    "appmodules" : 
        {
            "Categories" : [],
            "Languages" : [],
            "LangKeys" : { "en" => {"LangKey" => "KeyValue"} }
        }
  }
}
```
