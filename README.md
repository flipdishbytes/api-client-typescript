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
import { StoresApi } from '@flipdish/api-client-typescript';

let storesApi = new StoresApi();
storesApi.accessToken = '<your_access_token>';
storesApi.getStores('mexican cafe', 1, 20)
.then(response => {
        response.body.Data.map(store => console.log(store));
    }).catch(error => {
        console.error(error);    
    });
```
