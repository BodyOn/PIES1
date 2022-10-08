pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Gerando emails'
        mail(subject: '[CI/CD] Pipeline start', body: 'Pipeline sendo executada', charset: 'UTF-8', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com, jejosu346@gmail.com, isaniovitor@alu.ufc.br, falcaof14@alu.ufc.br')
        echo 'Emails enviados com sucesso'
      }
    }

  }
}