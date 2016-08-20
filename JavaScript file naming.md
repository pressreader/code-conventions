#JavaScript app conventions

PressReader JavaScript application cosists of multiple independed modules.
Each module is a separate folder in `src` and can have sub-modules/features that are also separate folders.
Put your JavaScipt files into `src/[modulename]` or in `src/[modulename]/[featurename]` folders. Please use common sense and separation of 
concerns principle when making a decision where to put your file.

1. Use dot to separate parts of filename and foldername.
2. Avoid using too many nested folders (1-2 is enough in most cases)

See example:
```
catalog
├─── catalog.viewmodel.js
├─── catalog.dialog.js
├─── catalog.provider.js
├─── catalog.service.js
routing
├─── constraints
│    ├─── article.constraint.js
│    └─── country.validate.js
├─── resolvers
│    ├─── publication.js
│    └─── publication.provider.js
├─── route.js
└─── route.constraint.js
video
├─── autoplay.js
├─── player.base.js
├─── player.factory.js
└─── jw.player.js
```
