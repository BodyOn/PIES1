pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Gerando emails'
        mail(subject: '[CI/CD] Execu��o da pipeline ', body: 'Pipeline sendo executada para gera��o de relat�rios', charset: 'UTF-8', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com, jejosu346@gmail.com')
        echo 'Emails enviados com sucesso'
      }
    }

  }
}