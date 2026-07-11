# Hands-On 8 - HTTP Client, API Integration, Observables & Interceptors

## Objective

Integrate the Student Course Portal with a REST API using Angular HttpClient, apply RxJS operators, and implement HTTP Interceptors.

---

## Topics Covered

- HttpClient
- JSON Server
- GET
- POST
- PUT
- DELETE
- RxJS Operators
- map
- tap
- catchError
- retry
- switchMap
- HTTP Interceptors
- Loading Spinner

---

## Install JSON Server

```bash
npm install -g json-server
```

---

## Install HttpClient

Standalone Angular

```typescript
provideHttpClient()
```

---

## Run JSON Server

```bash
json-server --watch db.json --port 3000
```

---

## Generate

```bash
ng generate interceptor interceptors/auth

ng generate interceptor interceptors/error-handler

ng generate interceptor interceptors/loading
```

---

## Files

- db.json
- course.service.ts
- course-list.component.ts
- auth.interceptor.ts
- error-handler.interceptor.ts
- loading.interceptor.ts
- loading.service.ts
