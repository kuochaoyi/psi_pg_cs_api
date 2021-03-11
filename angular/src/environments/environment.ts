import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'PSIpgCSapi',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44361',
    redirectUri: baseUrl,
    clientId: 'PSIpgCSapi_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone PSIpgCSapi',
  },
  apis: {
    default: {
      url: 'https://localhost:44318',
      rootNamespace: 'PSIpgCSapi',
    },
  },
} as Environment;
