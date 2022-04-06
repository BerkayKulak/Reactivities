import { Formik } from "formik";
import React from "react";
import { Button, Form } from "semantic-ui-react";
import MyTextInput from "../../app/common/form/MyTextInput";

export default function LoginForm() {
  return (
    <Formik
      initialValues={{ email: "", password: "" }}
      onSubmit={(values) => console.log(values)}
    >
      {({ handleSubmit }) => (
        <Form className="ui form" onSubmit={handleSubmit} autoComplete="off">
          <MyTextInput placeholder="email" name="email" />
          <MyTextInput placeholder="password" name="password" type="password" />
          <Button positive content="Login" type="submit" fluid />
        </Form>
      )}
    </Formik>
  );
}
