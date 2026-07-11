# Hands-On 5 - Reactive Forms, FormBuilder, FormArray & Custom Validators

## Objective

Build a reactive enrollment form using FormBuilder with validation, custom validators, async validators, and dynamic FormArray controls.

---

## Topics Covered

- ReactiveFormsModule
- FormBuilder
- FormGroup
- FormControl
- FormArray
- Built-in Validators
- Custom Validator
- Async Validator
- Dynamic Controls

---

## Generate Component

```bash
ng generate component pages/reactive-enrollment-form
```

---

## Add Route

```typescript
{
    path: 'enroll-reactive',
    component: ReactiveEnrollmentFormComponent
}
```

---

## Import

```typescript
import { ReactiveFormsModule } from '@angular/forms';
```

---

## Files

- reactive-enrollment-form.component.ts
- reactive-enrollment-form.component.html
