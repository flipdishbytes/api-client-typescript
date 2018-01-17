# @flipdish/api-client-typescript
Typescript Flipdish API client
## Installation 
```sh
npm install @flipdish/api-client-typescript --save
yarn add @flipdish/api-client-typescript
bower install @flipdish/api-client-typescript --save
```
## Usage
### TypeScript
```typescript
import * as flipdish from '@flipdish/api-client-typescript';

let storesApi = new flipdish.StoresApi();
storesApi.accessToken = '<your_access_token>';
storesApi.getAllStores('1.0', 'mexican cafe', 1, 20)
.then(response => {
        console.log(response);
    }).catch(error => {
        console.error(error);    
    });
```